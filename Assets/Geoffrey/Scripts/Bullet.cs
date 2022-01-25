using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static float speed = 10f;
    public int damage;
    private Transform _target;
    private float _timer;
    
    void Start()
    {
        _target = EnemyMovement.Target;
    }
    
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 3)
        {
            Destroy(gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, speed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
