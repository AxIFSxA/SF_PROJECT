using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBulletFire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigbulletObject;
    public GameObject bigbulletFireObject;
    // Start is called before the first frame update
    public float fireCooldown = 10f;
    float lastFireTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && Time.time >= lastFireTime + fireCooldown)
        {
            GameObject bullet = Instantiate(bigbulletObject);
            bullet.transform.position = bigbulletFireObject.transform.position;

            lastFireTime = Time.time;
        }
    }
}
