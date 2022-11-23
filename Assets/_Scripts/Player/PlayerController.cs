using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Referances")]
    [SerializeField] private FloatingJoystick joystick;
    
    [Header("Values")] 
    [SerializeField] private float forwardSpeed;

    [SerializeField] private float horizontalSpeed;
    

    private void Update()
    {
        StartGame();
    }


    private void StartGame()
    {
        if (!GameController.isLevelStarted)
        {
            return;
        }
        MoveHorizontal();
        MoveForward();
    }
    
    private void MoveHorizontal()
    {
        var horizontalInput = joystick.Horizontal;
        
        HandleRotation(horizontalInput);
        transform.Translate(Vector3.right * (Time.deltaTime * horizontalSpeed * horizontalInput));
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
