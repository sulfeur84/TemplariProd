using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject enemy = GameObject.FindWithTag("Enemy");
            enemy.GetComponent<EnemyMovement>().Dead();
        }
    }
}
