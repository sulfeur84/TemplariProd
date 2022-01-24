using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMoving : MonoBehaviour
{
    public float Speed;
    private float movingHorizontal, movingVertical;
    private Transform target;
    private void Start()
    {
        target = transform.Find("Target");
        target.position = transform.Find("Vision").position;
    }

    void Update()
    {
        transform.Translate(Vector3.left * movingHorizontal * Speed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(target.position - transform.position, Vector3.left);
        transform.Translate(Vector3.back * movingVertical * Speed * Time.deltaTime);
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
