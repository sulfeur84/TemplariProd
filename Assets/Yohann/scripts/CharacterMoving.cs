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
    private Vector3 rotationHorizontal, rotationVertical;
    private void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0,movingHorizontal ,0 * Time.deltaTime);
        transform.Translate(Vector3.right * movingHorizontal * Speed * Time.deltaTime);
        transform.Translate(Vector3.forward * movingVertical * Speed * Time.deltaTime);
    }

    private void OnHorizontal(InputValue PlayerInput)
    {
        movingHorizontal = PlayerInput.Get<float>();
    }

    private void OnVertical(InputValue PlayerInput)
    {
        movingVertical = PlayerInput.Get<float>();
    }
}
