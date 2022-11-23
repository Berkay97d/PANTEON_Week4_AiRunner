using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.Player;
using UnityEngine;



public class PlayerMover : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private FloatingJoystick joystick;

    [Header("Values")] 
    public float forwardSpeed;
    public float horizontalSpeed;
    public float xLimit;
    
    

    private void Update()
    {
        StartGame();
    }


    private void StartGame() //OYUN BAŞLADIYSA KARAKTERİ HAREKET ETTİRMEK İÇİN STATE RUNNİNGE GEÇTİ Mİ DİYE BAKIYORUZ
    {
        if (Player.PlayerState == PlayerStates.Running)
        {
            MoveHorizontal();
            MoveForward();
        }
    }
    
    private void MoveHorizontal()
    {
        var horizontalInput = joystick.Horizontal;
        
        HandleRotation(horizontalInput);
        transform.Translate(Vector3.right * (Time.deltaTime * horizontalSpeed * horizontalInput));
        StayInGameArea();
    }

    private void StayInGameArea()
    {
        if (transform.position.x > xLimit)
        {
            transform.position = new Vector3(xLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xLimit)
        {
            transform.position = new Vector3(-xLimit, transform.position.y, transform.position.z);
        }
    }
    
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * (forwardSpeed * Time.deltaTime));
    }

    private void HandleRotation(float input)
    {
        var rotateValue = 15 * input;
        var rotationVector = new Vector3(0, rotateValue, 0);
        
        transform.rotation = Quaternion.Euler(rotationVector);
    }
    
    
}
