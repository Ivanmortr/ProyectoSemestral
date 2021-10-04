using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clase1 : MonoBehaviour
{

    public bool position1 = false;
    public bool scale1 = false;
    public bool position2 = false;
    public bool position2A = false;
    public bool scale2 = false;
    public int velocidad = 0;
    public int limit = 2;
  
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))//Cuando se presione la tecla x
        {
            transform.localScale = transform.localScale * 3; //multiplicamos el vector localScale por un numero escalar.

        }
        if (Input.GetKeyDown(KeyCode.Y))//Cuando se presione la tecla x
        {
            //transform.position= transform.position = new Vector3(1,0,0); //sumamos el vector position por un numero escalar.
            transform.position += new Vector3(1, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.position += new Vector3(0, 1, 0);//se aumenta la posicion en y del vector position
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = transform.localScale / 3;//se divide entre 3 el vector localscale
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // transform.localScale = transform.localScale ;
            //transform.position(0, positionPerSecond * Time.deltaTime);
            position1 = true;          //se establece la posicion en verdadero
            scale1 = false;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            //Escala1(velocidad); 
            scale1 = true;
            position1 = false;
        }
        if (scale1)
        {
            Escala1(velocidad); 
        }
        if (position1)
        {
            transform.localScale = new Vector3(transform.localScale.x + (2 * Time.deltaTime), transform.localScale.y + (2 * Time.deltaTime), transform.localScale.z + (2 * Time.deltaTime));
            transform.position += new Vector3(0, 2 * Time.deltaTime, 0); // la escala y la posicion aumenta
        }
        if (transform.localScale.x <= 1)
        {
            scale1 = false; //si la posicion llega abajo de 1 se detiene scale 1
        }
        if(position2)
        {
            transform.position += new Vector3(10 * Time.deltaTime, 8 * Time.deltaTime, 0);   //hace que el movimiento sea positivo en x y en y
            Debug.Log("Postition2"); 
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            position2 = true;
            Debug.Log("Pressed L");
        }
        if (position2A)
        {
            transform.position = new Vector3(transform.position.x + (10 * Time.deltaTime), transform.position.y - (8 * Time.deltaTime), 0);
            position2 = false;

            //hace que la poscicion en x se mueva constantemente positiva y en y constante negativa
            Debug.Log("Postition2A");
        }
        if (transform.position.y >= limit)
        {
           
            position2A = true;
                                  //cuando llega a 0 se activa position2A
            Debug.Log("Llega a 0");
        }
        if (transform.position.y <= -4)
        {
            position2 = true;               //cuando llega a -4 desactiva position2A 
            position2A = false;
        }

    }

    private void Escala1(int numero)
    {
        transform.localScale = new Vector3(transform.localScale.x - (numero * Time.deltaTime), transform.localScale.y - (numero * Time.deltaTime), transform.localScale.z - (numero * Time.deltaTime));
        transform.position -= new Vector3(0, numero * Time.deltaTime, 0);
    }

}
