using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int health;
    private GameObject _enemy;
    private GameObject _bullet;
    void Start()
    {
        
    }
    
    void Update()
    {
        _enemy = GameObject.FindWithTag("Enemy");
        _bullet = GameObject.FindWithTag("Bullet");
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == _enemy.GetComponent<Collider>())
        {
            health -= _enemy.GetComponent<EnemyData>().damage;
        }
        else if (other == _bullet.GetComponent<Collider>())
        {
            health -= _bullet.GetComponent<Bullet>().damage;
        }
    }
}
