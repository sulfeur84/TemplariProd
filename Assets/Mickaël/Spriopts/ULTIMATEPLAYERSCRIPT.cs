using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Random = System.Random;

public class ULTIMATEPLAYERSCRIPT : MonoBehaviour
{
    [SerializeField] private float HP = 100f;
    
    private float movingVertical;
    private float rotationHorizontal;
    public GameObject DetruitSah;
    public Image HealthBar;
    private Random random = new Random();
    public float Speed, DommageParCoup, rotationSpeed;
    private float RecuperationDommage, RecuperationVitesse, GlobalTimer;
    public bool Speeded, Slowed, DomageBoost, Empoisonnee;
    public Vector3 respawnPos;

    public Animator anim;
    
    private void Start()
    {
        HealthBar.fillAmount = HP;
        RecuperationDommage = DommageParCoup;
        RecuperationVitesse = Speed;
        respawnPos = GetComponent<Transform>().position;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationHorizontal * rotationSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * movingVertical * Speed * Time.deltaTime);
        HealthBar.fillAmount = HP;
        if (HP <= 0)
        {
            transform.position = respawnPos;
            HP = HealthBar.fillAmount;
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
            Speed = RecuperationVitesse - (RecuperationVitesse * 25 / 100);
            if (GlobalTimer >= 10)
            {
                GlobalTimer = 0;
                Slowed = false;
                Speed = RecuperationVitesse;
            }
            
        }
        
        //ETATS NEED FOR SPEED
        if (Speeded)
        {
            GlobalTimer += Time.deltaTime;
            Speed = RecuperationVitesse + (RecuperationVitesse * 25 / 100);
            if (GlobalTimer >= 10)
            {
                GlobalTimer = 0;
                Speeded = false;
                Speed = RecuperationVitesse;
            }
            
        }
        
    }

    private void OnHorizontal(InputValue PlayerInput)
    {
        rotationHorizontal = PlayerInput.Get<float>();
    }

    private void OnVertical(InputValue PlayerInput)
    {
        movingVertical = PlayerInput.Get<float>();
        anim.SetBool("Run", true);
        if(PlayerInput.Get<float>() == 0) anim.SetBool("Run", false);
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
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
