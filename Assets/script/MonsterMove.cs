using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public float spd = 3.0f;

    public GameObject target;
    Vector3 dircet = Vector3.down;
    // Start is called before the first frame update
    private void Start()
    {
        int rndNum = Random.Range(0, 10);

        if(rndNum % 3 ==0)
        {
            
            dircet = target.transform.position-transform.position;
            dircet.Normalize(); 
        }
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = transform.position+dircet*spd*Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

        Destroy(gameObject);
    }
}
