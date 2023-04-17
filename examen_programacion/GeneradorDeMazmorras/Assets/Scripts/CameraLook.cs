using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
        //aqui definimos la sensibilidad del raton, el cual controla el movimiento de camara//
        public float mouseSensitivity = 60f;  
        public Transform playerBody;  
        float xRotation = 0f;  


        void Update()
        {


            // se defino el movimiento de la camara con base al movimiento del raton//

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }

}
