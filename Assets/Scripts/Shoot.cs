using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform projectileSpawn;
    public GameObject projectile;

    public float nextFire = 1.0f;
    public float currenttime = 0.0f;

    
    void Start()
    {
        projectileSpawn = this.gameObject.transform;
    }

    
    void Update()
    {
        shoot();
    }

    public void shoot()
    {
        currenttime += Time.deltaTime;

        if (Input.GetButton("Fire1") && currenttime > nextFire)
        {
            nextFire += currenttime;

            Instantiate(projectile, projectileSpawn.position, Quaternion.identity); //shoot! create the object
            
            nextFire -= currenttime;
            currenttime = 0.0f;
        }
    }
}
