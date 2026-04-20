using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    public GameObject bulletObject;
    public GameObject bulletFireObject;
    // Start is called before the first frame update
    public float fireCooldown = 0.5f;
    float lastFireTime = 0f;
    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetButtonDown("Jump") && Time.time >= lastFireTime + fireCooldown)
        {
            GameObject bullet = Instantiate(bulletObject);
            bullet.transform.position = bulletFireObject.transform.position;

            lastFireTime = Time.time;
        }
    }
}