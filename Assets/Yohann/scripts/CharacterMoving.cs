using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Composites;
using UnityEngine.InputSystem.Controls;

public class CharacterMoving : MonoBehaviour
{
    public float Speed;
    private float movingHorizontal, movingVertical;
    private float rotationHorizontal, rotationVertical;
    private void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.right * rotationHorizontal * Time.deltaTime);
        transform.Translate(Vector3.right * movingHorizontal * Speed * Time.deltaTime);
        transform.Translate(Vector3.forward * movingVertical * Speed * Time.deltaTime);
        Debug.Log(rotationHorizontal + rotationVertical);
    }
    
    private void OnHorizontal(InputValue PlayerInput)
    {
        movingHorizontal = PlayerInput.Get<float>();
        rotationHorizontal = PlayerInput.Get<float>();
    }

    private void OnVertical(InputValue PlayerInput)
    {
        movingVertical = PlayerInput.Get<float>();
        rotationVertical = PlayerInput.Get<float>();
    }
}
