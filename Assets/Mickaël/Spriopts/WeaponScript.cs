using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponScript : MonoBehaviour
{
    private Animator anim;
    private InputTest IWANTTOATTACK;
    private InputAction ATTACK;

    private void Awake()
    {
        IWANTTOATTACK = new InputTest();
    }

    private void OnEnable()
    {
        ATTACK = IWANTTOATTACK.Player.Fire;
        ATTACK.Enable();
    }

    private void OnDisable()
    {
        ATTACK.Disable();
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (ATTACK.IsPressed())
        {
            anim.SetBool("Attack", true);
        }
        else if (ATTACK.IsPressed()== false)
        {
            anim.SetBool("Attack", false);
        }
    }

}
