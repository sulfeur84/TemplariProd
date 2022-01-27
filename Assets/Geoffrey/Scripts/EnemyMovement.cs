using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private List<Transform> _possibleTarget = new List<Transform>();
    public EnemyData enemyData;
    private SphereCollider detectionZone;
    public static Transform Target;
    public static Vector3 position;
    private float _shortestTarget = 0f;
    private float _distance;
    private float _timer = 0f;
    private bool inRange = false;

    void Start()
    {
        detectionZone = GetComponent<SphereCollider>();
        detectionZone.radius = enemyData.range;
        position = transform.position;
        _shortestTarget = Mathf.Infinity;
    }

    void Update()
    {
        _timer += Time.deltaTime;
        Target = FindClosestTarget(Target, _possibleTarget, _shortestTarget, position);
        _distance = Vector3.Distance(Target.position, transform.position);
        if (inRange && Target != null)
        {
            transform.LookAt(Target);
            Attack();
        }
    }
                                      
    public static Transform FindClosestTarget(Transform finalTarget, List<Transform> possibleTargetList, float shortestTarget, Vector3 objectPosition)
    {
        Transform nearestTarget = null;

        foreach (Transform target in possibleTargetList)
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

    private void Attack()
    {
        if (enemyData.enemyType == "Cac")
        {
            position = Vector3.MoveTowards(position, Target.transform.position, enemyData.speed * Time.deltaTime);
            transform.position = position;
        }
        else if (enemyData.enemyType == "FlyingCac")
        {
            position = Vector3.MoveTowards(position, Target.transform.position, enemyData.speed * Time.deltaTime);
            transform.position = position;
        }
        else if (enemyData.enemyType == "Shooter" || enemyData.enemyType == "Boss")
        {
            if (_distance >= 2)
            {
                position = Vector3.MoveTowards(position, Target.transform.position, enemyData.speed * Time.deltaTime);
                transform.position = position;
            }
            if (_distance <= enemyData.attackRange)
            {
                if (_timer >= enemyData.reloadTime)
                {
                    Rigidbody rb = Instantiate(enemyData.projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
                    rb.AddForce(transform.forward * Bullet.speed, ForceMode.Impulse);
                    _timer = 0f;
                }
            }
            if (enemyData.enemyType == "Boss")
            {
                position = Vector3.MoveTowards(position, Target.transform.position, enemyData.speed * Time.deltaTime);
                transform.position = position;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _possibleTarget.Add(other.transform);
            inRange = true;
        }
    }
}
