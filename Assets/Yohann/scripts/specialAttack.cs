using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class specialAttack : MonoBehaviour
{
    public GameObject specialAttackBox;
    public GameObject Player;
    public float AttackDuration;
    public static bool InAttack;
    public bool specialCooldown;
    public float CooldownTime;
    // Start is called before the first frame update
    private void Start()
    {
        specialAttackBox.SetActive(false);
    }

    private void Update()
    {
        specialAttackBox.transform.position = Player.transform.position;
        specialAttackBox.transform.rotation = Player.transform.rotation;
    }

    void OnSpecialAttack()
    {
        if(InAttack == false && specialCooldown == false)
        {
            InAttack = true;
            specialCooldown = true;
            specialAttackBox.SetActive(true);
            Invoke("DestroyBox", AttackDuration);
        }
    }

    void DestroyBox()
    {
        specialAttackBox.SetActive(false);
        InAttack = false;
        Invoke("Cooldown",CooldownTime);
    }

    void Cooldown()
    {
        specialCooldown = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject enemy = GameObject.FindWithTag("Enemy");
            enemy.GetComponent<EnemyMovement>().Dead();
        }
    }
}
