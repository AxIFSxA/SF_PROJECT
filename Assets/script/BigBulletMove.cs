using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBulletMove : MonoBehaviour
{
    float spd = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * spd * Time.deltaTime);
    }
}
