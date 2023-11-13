using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
   
    
    [SerializeField] private float speed = 10f;
    [SerializeField] private float horizontalSpeed = 5f;
    [SerializeField] private float rotateSpeed = 6f;
    [SerializeField] private float bottomBound = -10f;
    [SerializeField] private GameObject camera;
    [SerializeField] private Vector3 offset;




    private float rotation;
    private float horizontalInput;

    

    


    private void Update()
    {
        
        horizontalInput = Input.GetAxis("Vertical");

        //Movimiento hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Rotacion de arriba abajo con indicacion del usuario 
         rotation = Input.GetAxis("Vertical") * rotateSpeed * Time.deltaTime;


        if (transform.position.z > 220)
        {
            
            Debug.Log("Tu ganas");
                  
        }

        camera.transform.position = transform.position + offset;
    }

    private void LateUpdate()
    {
        transform.Rotate(rotation, 0f, 0f);
        

    }
  
}

