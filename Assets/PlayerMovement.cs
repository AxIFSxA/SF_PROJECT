using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float spd = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

       

        Vector3 direct = new Vector3(h, v, 0);

        transform.position = transform.position + direct * spd * Time.deltaTime;
    }
}
