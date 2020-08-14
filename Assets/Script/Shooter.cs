using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour

{
    public GameObject projectilePrefab;
  


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = GameObject.Instantiate(projectilePrefab,
                new Vector3(projectilePrefab.transform.position.x,transform.position.y,0), 
                Quaternion.identity);

        }
    }
}
