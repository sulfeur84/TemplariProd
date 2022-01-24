using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Moove : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    [SerializeField] private int HP = 100;

    public Slider HealthBar;

    public GameObject DetruitSah;
    // Start is called before the first frame update
    void Start()
    {
        HealthBar.maxValue = HP;
        HealthBar.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementInput();
        HealthBar.value = HP;
        if(HP==0) Destroy(this.gameObject);
    }

    void HandleMovementInput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_horizontal, 0, _vertical);
        transform.Translate(_movement * movementSpeed * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ennemy"))
        {
            HP -= 25;
        }
    }

    private void OnDestroy()
    {
        Destroy(DetruitSah);
    }
}
