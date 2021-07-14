using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
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
        enemyShoot();
        
    }

    public void enemyShoot()
    {
        currenttime += Time.deltaTime;

        //if (currenttime > nextFire) //FOR AI
        if(Input.GetButton("Fire2") && currenttime > nextFire)
        {
            nextFire += currenttime;

            Instantiate(projectile, projectileSpawn.position, Quaternion.identity); //shoot! create the object

            nextFire -= currenttime;
            currenttime = 0.0f;
        }
    }
}
