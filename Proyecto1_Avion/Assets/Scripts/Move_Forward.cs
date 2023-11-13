using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Object : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset = new Vector3();
  


   
    void LateUpdate()
    {
      transform.position = player.transform.position + offset;
      transform.rotation = player.transform.rotation;
    }
}
