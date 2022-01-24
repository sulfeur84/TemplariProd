using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class Moove : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    [SerializeField] private float HP = 100f;

    public bool Empoisonnee;
    public Slider HealthBar;
    private Random random = new Random();
    public GameObject DetruitSah;
    public float DommageParCoup = 50f;
    public float GlobalTimer;
    public bool DomageBoost;
    private float RecuperationDommage;
    private float RecuperationVitesse;
    public bool Speeded;
    public bool Slowed;

    void Start()
    {
        HealthBar.maxValue = HP;
        HealthBar.minValue = 0;
        RecuperationDommage = DommageParCoup;
        RecuperationVitesse = movementSpeed;
    }


    void Update()
    {
        HandleMovementInput();
        HealthBar.value = HP;
        if(HP==0) Destroy(this.gameObject);
        // ETATS EMPOISONNER
        if (Empoisonnee)
        {
            for (float Timer = 10; Timer < 10; Timer += Time.deltaTime)
            {
                HP -= (HP * 25 / 100) * Time.deltaTime;
            }
            Empoisonnee = false;
        }

        //ETATS BOOST DE DOMMAGE
        if (DomageBoost)
        {
            for (float Timer = 10; Timer < 10; Timer += Time.deltaTime)
            {
                DommageParCoup = RecuperationDommage + (RecuperationDommage * 25 / 100);
            }
            DomageBoost = false;
            DommageParCoup = RecuperationDommage;
        }
        
        //ETATS SLOW
        if (Slowed)
        {
            for (float Timer = 10; Timer < 10; Timer += Time.deltaTime)
            {
                movementSpeed = RecuperationVitesse - (RecuperationVitesse * 25 / 100);
            }
            Slowed = false;
            movementSpeed = RecuperationVitesse;
        }
        
        //ETATS NEED FOR SPEED
        if (Speeded)
        {
            for (float Timer = 10; Timer < 10; Timer += Time.deltaTime)
            {
                movementSpeed = RecuperationVitesse + (RecuperationVitesse * 25 / 100);
            }
            Speeded = false;
            movementSpeed = RecuperationVitesse;
        }
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
            HP = HP - (HP*25/100);
        }

        if (other.gameObject.CompareTag("Burger"))
        {
            Destroy(other.gameObject);
            int Binary = random.Next(0, 2);
            Debug.Log(Binary);
            if (Binary == 1) HP = HP + (HP * 25 / 100);
            else Empoisonnee = true;
        }

        if (other.gameObject.CompareTag("Binouze"))
        {
            Destroy(other.gameObject);
            int Binary = random.Next(0, 2);
            Debug.Log(Binary);
            if (Binary == 1) DomageBoost = true;
            else  HP = HP - (HP * 25 / 100);
        }

        if (other.gameObject.CompareTag("Tongue"))
        {
            Destroy(other.gameObject);
            int Binary = random.Next(0, 2);
            Debug.Log(Binary);
            if (Binary == 1) Speeded = true;
            else Slowed = true;

        }
    }
    

    private void OnDestroy()
    {
        Destroy(DetruitSah);
    }
}
