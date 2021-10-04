using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : MonoBehaviour
{

    public GameObject sphereSon;
    public float ppuntoSon;
    public float distanciaSon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanciaSon = Vector3.Distance(sphereSon.transform.position, transform.position);
        ppuntoSon = Vector3.Dot(transform.right.normalized, sphereSon.transform.right.normalized);

        if(distanciaSon<1f)
        {
            if (ppuntoSon < -0.9f)
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }

        if(transform.tag == "5sef")
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }


        

    }
}
