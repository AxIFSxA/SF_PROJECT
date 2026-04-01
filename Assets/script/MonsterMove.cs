using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public float spd = 3.0f;

    GameObject target;
    Vector3 dircet = Vector3.down;

    public GameObject prefabsExplosion;

    int rndNum;


    // Start is called before the first frame update
    private void Start()
    {
        target = GameObject.Find("Chracter");
        rndNum = Random.Range(0, 10);

    }

    // Update is called once per frame
    private void Update()
    {
        if (rndNum % 3 == 0)
        {

            dircet = target.transform.position - transform.position;
            dircet.Normalize();
        }
        transform.position = transform.position+dircet*spd*Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosionOBJ = Instantiate(prefabsExplosion);
        explosionOBJ.transform.position = transform.position;   

        Destroy(collision.gameObject);

        Destroy(gameObject);
    }
}
