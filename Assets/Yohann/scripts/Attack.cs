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
    public bool InSimpleAttack;
    // Start is called before the first frame update
    private void Start()
    {
        AttackBox.SetActive(false);
        InSimpleAttack = false;
    }

    private void Update()
    {
        InSimpleAttack = GetComponent<specialAttack>().InAttack;
        AttackBox.transform.position = transform.position;
        AttackBox.transform.rotation = Player.transform.rotation;
    }

    void OnSimpleAttack()
    {
        if(InSimpleAttack == false)
        {
            InSimpleAttack = true;
            AttackBox.SetActive(true);
            Invoke("DestroyBox", AttackDuration);
        }
    }

    void DestroyBox()
    {
        AttackBox.SetActive(false);
        InSimpleAttack = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.LogWarning("j'aimerai un void dead pour détruire l'énnemi pls");
            GameObject enemy = GameObject.FindWithTag("Enemy");
        }
    }
}
