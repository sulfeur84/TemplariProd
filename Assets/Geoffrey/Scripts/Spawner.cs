using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemy;
    [SerializeField]
    private int range;
    [SerializeField]
    private int enemyCount;
    [SerializeField]
    private float _spawnTime;
    private GameObject[] _possibleTarget;
    private float _shortestTarget = 0f;
    private float _distance;
    private Transform _target;
    private Vector3 _position;
    private float _timer = 0;

    private void Start()
    {
        _position = transform.position;
        _possibleTarget = GameObject.FindGameObjectsWithTag("Player");
        _shortestTarget = Mathf.Infinity;
    }

    void Update()
    {
        _timer += Time.deltaTime;
        _target = EnemyMovement.FindClosestTarget(_target, _possibleTarget, _shortestTarget, _position);
        _distance = Vector3.Distance(_target.transform.position, this.transform.position);
        if (_distance <= range)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        if (_timer >= _spawnTime && enemyCount != 0)
        {
            Instantiate(_enemy, transform.position, Quaternion.identity);
            enemyCount--;
            _timer = 0;
        }
    }
}
