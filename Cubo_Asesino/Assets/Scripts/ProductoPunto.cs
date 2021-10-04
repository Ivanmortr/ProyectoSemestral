using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductoPunto : MonoBehaviour
{
    
    public GameObject sphereMother; 
    public float distancia;
    public float ppunto;
    public float facing;
    public float pcross;
    PlayerMovement playerMovement;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(sphereMother.transform.position, transform.position);
        //facing = Quaternion.Angle(sphereMother.transform.rotation, transform.rotation);

        ppunto = Vector3.Dot(transform.right.normalized, sphereMother.transform.right.normalized);
        //pcross = Vector3.Cross(transform.right.normalized, sphereMother.transform.right.normalized);
        

        if(sphereMother.transform.rotation.y==playerMovement.y)
        {
            if (distancia < 10f)
            {

                if (ppunto < -0.9f)
                {
                    GetComponent<Renderer>().material.color = Color.magenta;
                }


            }

        }

              
        }


       
    }

   /* public void RotationDetect()
    {
        if(facing<= -170)
        {
            
        }
    }*/

