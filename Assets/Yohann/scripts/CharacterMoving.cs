using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Composites;
using UnityEngine.InputSystem.Controls;

public class CharacterMoving : MonoBehaviour
{
    public float Speed;
    private float movingVertical;
    private float rotationHorizontal;
    public float rotationSpeed;
    private void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationHorizontal * rotationSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * movingVertical * Speed * Time.deltaTime);
    }
    
    private void OnHorizontal(InputValue PlayerInput)
    {
        rotationHorizontal = PlayerInput.Get<float>();
    }

    private void OnVertical(InputValue PlayerInput)
    {
        movingVertical = PlayerInput.Get<float>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("OUCHHHH");
        }
    }
}
