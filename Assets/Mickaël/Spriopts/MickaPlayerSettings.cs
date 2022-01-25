using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class MickaPlayerSettings : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    [SerializeField] private float HP = 100f;

    public bool Empoisonnee;
    public Slider HealthBar;
    private Random random = new Random();
    public GameObject DetruitSah;
    public float DommageParCoup = 50f;
    public bool DomageBoost;
    private float RecuperationDommage;
    private float RecuperationVitesse;
    public bool Speeded;
    public bool Slowed;
    private float GlobalTimer;
    public Vector3 respawnPos;

    void Start()
    {
        HealthBar.maxValue = HP;
        HealthBar.minValue = 0;
        RecuperationDommage = DommageParCoup;
        RecuperationVitesse = movementSpeed;
        respawnPos = GetComponent<Transform>().position;
    }


    void Update()
    {
        HandleMovementInput();
        HealthBar.value = HP;
        if (HP <= 0)
        {
            transform.position = respawnPos;
            HP = HealthBar.maxValue;
        }
        
        
        // ETATS EMPOISONNER
        if (Empoisonnee)
        {
            GlobalTimer += Time.deltaTime;
            HP -= 25/10 * Time.deltaTime;
            if (GlobalTimer >= 10)
            {
                    GlobalTimer = 0;
                    Empoisonnee = false;
            }
            
        }

        //ETATS BOOST DE DOMMAGE
        if (DomageBoost)
        {
            GlobalTimer += Time.deltaTime;
            DommageParCoup = RecuperationDommage + (RecuperationDommage * 25 / 100);
                if (GlobalTimer >= 10)
                {
                    GlobalTimer = 0;
                    DomageBoost = false;
                    DommageParCoup = RecuperationDommage;
                }
            
        }
        
        //ETATS SLOW
        if (Slowed)
        {
            GlobalTimer += Time.deltaTime;
            movementSpeed = RecuperationVitesse - (RecuperationVitesse * 25 / 100);
                if (GlobalTimer >= 10)
                {
                    GlobalTimer = 0;
                    Slowed = false;
                    movementSpeed = RecuperationVitesse;
                }
            
        }
        
        //ETATS NEED FOR SPEED
        if (Speeded)
        {
            GlobalTimer += Time.deltaTime;
            movementSpeed = RecuperationVitesse + (RecuperationVitesse * 25 / 100);
                if (GlobalTimer >= 10)
                {
                    GlobalTimer = 0;
                    Speeded = false;
                    movementSpeed = RecuperationVitesse;
                }
            
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
            HP -= 25;
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

        if (other.gameObject.CompareTag("Respawn"))
        {
            respawnPos = other.transform.position;
        }
    }
    

    private void OnDestroy()
    {
        Destroy(DetruitSah);
    }
}
