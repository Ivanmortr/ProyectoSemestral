using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float velocity = 3;
    public float y;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * velocity * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocity * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.E))
        {
            y += Time.deltaTime * 40;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            y -= Time.deltaTime * 40;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
    }
}
