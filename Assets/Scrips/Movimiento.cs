using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    //EL MOVIMIENTO ES FRAME POR FRAME

    float velocidad = 10f;


    //EL MOVIMIENTO DE UN JUGADOR DEPENDE DE LOS FPS DE LA APP

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("Estoy undiendo w");
            //transform.position +=Vector3.forward * velocidad * Time.deltaTime;//Forma mas extraña de hacerlo DEBIDO A QUE USA LAS COORDENADAS LOCALES SI SE ROTA PAILA
            //transform.position += transform.forward * velocidad;
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.position -= transform.right * velocidad * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {

            //transform.position -= transform.forward * velocidad;
            transform.position -= transform.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.position += transform.right * velocidad * Time.deltaTime;

        }

    }
}
