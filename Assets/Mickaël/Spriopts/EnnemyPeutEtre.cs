using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyPeutEtre : MonoBehaviour
{ 
    public Transform pointA;
    public Transform pointB;
    public Transform Joueur;
    public float DistanceToTarget = 0.1f;
    public bool IsReturn;
    public IAstate StatutActuel;
    public float Vitesse = 5.0f;
    public enum IAstate
    {
        Patrouille,
        Pourchasse
    };
    
    void Update()
    {
        switch(StatutActuel)
        {
            case IAstate.Patrouille:
                Pattern();
                break;
            case IAstate.Pourchasse:
                Poursuite();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void Poursuite()
    {
        if (Vector3.Distance(transform.position, Joueur.position) >= DistanceToTarget)
        {
            DistanceToTarget = 0.1f;
            Vitesse = 2f;
            transform.position += transform.forward * Vitesse * Time.deltaTime;
            transform.LookAt(Joueur.position);
        }
    }

    private void Pattern()
    {
        if (!IsReturn)
        {
            transform.position += (pointA.position - transform.position).normalized * Vitesse * Time.deltaTime;
            if (Vector3.Distance(transform.position, pointA.position) < DistanceToTarget) {
                transform.eulerAngles = new Vector3(0, 180 ,0);
                IsReturn = true;
            }
        }
        else 
        {
            transform.position += (pointB.position - transform.position).normalized * Vitesse * Time.deltaTime;
            if (Vector3.Distance(transform.position, pointB.position) < DistanceToTarget) {
                transform.eulerAngles = new Vector3(0, 0 ,0);
                IsReturn = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Joueur = other.transform;
            StatutActuel = IAstate.Pourchasse;
            Debug.Log("joueur détecté");
        }
        if (other.gameObject.CompareTag("Player4"))
        {
            Joueur = other.transform;
            StatutActuel = IAstate.Pourchasse;
            Debug.Log("joueur détecté");
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            Joueur = other.transform;
            StatutActuel = IAstate.Pourchasse;
            Debug.Log("joueur détecté");
        }
        if (other.gameObject.CompareTag("Player3"))
        {
            Joueur = other.transform;
            StatutActuel = IAstate.Pourchasse;
            Debug.Log("joueur détecté");
        }
        if (other.gameObject.CompareTag("Player"))
        {
            Joueur = other.transform;
            StatutActuel = IAstate.Pourchasse;
            Debug.Log("joueur détecté");
        }
    }

}
