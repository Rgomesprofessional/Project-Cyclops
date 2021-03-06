﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
    // Attributes
    private bool gyroEnabled;
    private Gyroscope gyro;
    private GameObject cameraContainer;
    private Quaternion rot;
    
    // Use this for initialization
    void Start()
    {
        // Makes the camera becomes the main view from the user
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);

        // Enables gyroscope
        gyroEnabled = EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        // Makes the camera to show the view accordiing to the mobile sensor.
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }
    }

    // Attach the values from the sensor so the camera can be moved according to it
    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }
}
