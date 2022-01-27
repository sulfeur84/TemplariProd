using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class WeaponScript : MonoBehaviour
{
    private Animator anim;
    private InputTest IWANTTOATTACK;
    private InputAction ATTACK;
    public Image Cooldown;
    public bool OnCooldown;
    private float timer;

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
        if (ATTACK.IsPressed() && !OnCooldown)
        {
            timer = 0;
            anim.SetBool("Attack", true);
            OnCooldown = true;
        }

        if (OnCooldown)
        {
            anim.SetBool("Attack", false);
            timer += Time.deltaTime;
            Cooldown.fillAmount = timer/10;
            if (timer >= 10)
            {
                OnCooldown = false;
            }
        }
    }

}
