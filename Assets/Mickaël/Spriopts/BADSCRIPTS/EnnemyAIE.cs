using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAIE : MonoBehaviour
{
    private int HP = 100;
    

    void Update()
    {
        if (HP == 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Weapon"))
        {
            HP -= 25;
        }
    }
}
