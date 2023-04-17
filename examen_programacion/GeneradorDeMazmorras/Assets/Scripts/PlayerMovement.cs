using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //aqui definimos la velocidad de nuestro personajey declaramos variables para su proximo uso// 
    public CharacterController controller;
    public float speed = 10f; 
    private Vector3 playerPosition;  
    private Quaternion playerRotation;
    public float X, Y;  



    void Update()
    {
      

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

     
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}