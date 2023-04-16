using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller; 
    // Se declara una variable publica para el controlador de personajes

    public float speed = 10f; 
    // Se declara una variable publica de velocidad para el movimiento del personaje

    private Vector3 playerPosition;
    // Se declara una variable privada para la posición del personaje
    private Quaternion playerRotation;
    // Se declara una variable privada para la rotación del personaje

    private Animator anim;  
    // Se declara una variable privada para el componente Animator del personaje
    public float X, Y;
    // Se declara una variable publica para las coordenadas del movimiento del personaje

    void start() 
        // Método para inicializar las variables
    {
        anim = GetComponent<Animator>();
        // Se asigna el componente Animator del GameObject al cual esta atachado este script a la variable anim
    }

    void Update() 
        // Método que se ejecuta una vez por frame
    {
        float x = Input.GetAxis("Horizontal"); 
        // Se asigna el valor del movimiento horizontal del personaje a la variable x
        float z = Input.GetAxis("Vertical"); 
        // Se asigna el valor del movimiento vertical del personaje a la variable z

        Vector3 move = transform.right * x + transform.forward * z;
        // Se calcula la dirección del movimiento del personaje

        controller.Move(move * speed * Time.deltaTime);
        // Se mueve el personaje en la dirección calculada con la velocidad asignada y el tiempo transcurrido desde el último frame

        anim.SetFloat("VelX", X); 
        // Se asigna el valor de X al parámetro "VelX" del Animator
        anim.SetFloat("VelY", Y); 
        // Se asigna el valor de Y al parámetro "VelY" del Animator
    }
}