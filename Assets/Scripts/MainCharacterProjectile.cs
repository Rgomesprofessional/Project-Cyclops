using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterProjectile : MonoBehaviour
{
    // Attributes
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;

    // Update is called once per frame
    void Update()
    {
        // Makes projectiles when the player shoots
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
    }
}