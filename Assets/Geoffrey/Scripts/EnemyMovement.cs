using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject[] _possibleTarget;
    public EnemyData enemyData;
    public static Transform Target;
    public static Vector3 Position;
    private float _shortestTarget = 0f;
    private float _distance;
    private float _timer = 0f;

    void Start()
    {
        Position = transform.position;
        _possibleTarget = GameObject.FindGameObjectsWithTag("Player");
        _shortestTarget = Mathf.Infinity;
    }

    void Update()
    {
        _timer += Time.deltaTime;
        Target = FindClosestTarget(Target, _possibleTarget, _shortestTarget, Position);
        _distance = Vector3.Distance(Target.transform.position, this.transform.position);
        if (_distance <= enemyData.range)
        {
            Attack();
        }
    }
                                      
    public static Transform FindClosestTarget(Transform finalTarget, GameObject[] possibleTargetList, float shortestTarget, Vector3 objectPosition)
    {
        GameObject nearestTarget = null;

        foreach (GameObject target in possibleTargetList)
        {
            float distanceToTarget = Vector3.Distance(objectPosition, target.transform.position);
            if (distanceToTarget < shortestTarget)
            {
                shortestTarget = distanceToTarget;
                nearestTarget = target;
            }
        }
        if (nearestTarget != null)
        {
            finalTarget = nearestTarget.transform;
        }

        return finalTarget;
    }

    public void Attack()
    {
        if (enemyData.enemyType == "Cac")
        {
            Position = Vector3.MoveTowards(Position, Target.transform.position, enemyData.speed * Time.deltaTime);
            transform.position = Position;
        }
        else if (enemyData.enemyType == "FlyingCac")
        {
            Position = Vector3.MoveTowards(Position, Target.transform.position, enemyData.speed * Time.deltaTime);
            transform.position = Position;
        }
        else if (enemyData.enemyType == "Shooter")
        {
            if (_distance >= 2)
            {
                Position = Vector3.MoveTowards(Position, Target.transform.position, enemyData.speed * Time.deltaTime);
                transform.position = Position;
            }
            if (_distance <= enemyData.attackDistance)
            {
                if (_timer >= enemyData.reloadTime)
                {
                    GameObject projectile = Instantiate(enemyData.projectile, transform) as GameObject;
                    projectile.GetComponent<Rigidbody>().velocity = Vector3.forward * Bullet.speed;
                    _timer = 0f;
                }
            }
        }
    }
}
