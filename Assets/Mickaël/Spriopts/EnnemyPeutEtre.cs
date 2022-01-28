using System;

using UnityEngine;

public class EnnemyPeutEtre : MonoBehaviour
{
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
