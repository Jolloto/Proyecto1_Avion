using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller_Rotate : MonoBehaviour
{
  [SerializeField] private float rotateSpeed = 6f;  

   void Update()
   {
    transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
   }
    
}
