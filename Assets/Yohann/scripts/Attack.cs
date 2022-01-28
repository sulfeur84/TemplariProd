using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    public GameObject AttackBox;
    public GameObject Player;
    public float AttackDuration;
    // Start is called before the first frame update
    private void Start()
    {
        AttackBox.SetActive(false);
    }

    private void Update()
    {
        AttackBox.transform.position = transform.position;
        AttackBox.transform.rotation = Player.transform.rotation;
    }

    void OnSimpleAttack()
    {
        if(specialAttack.InAttack == false)
        {
            specialAttack.InAttack = true;
            AttackBox.SetActive(true);
            Invoke("DestroyBox", AttackDuration);
        }
    }

    void DestroyBox()
    {
        AttackBox.SetActive(false);
        specialAttack.InAttack = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject enemy = GameObject.FindWithTag("Enemy");
        }
    }
}
