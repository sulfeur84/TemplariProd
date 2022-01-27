using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemy")]
public class EnemyData : ScriptableObject
{
    public GameObject enemyModel;
    public GameObject projectile;
    public string enemyType;
    public string enemyName;
    public float speed;
    public float reloadTime;
    public float range;
    public int health;
    public int damage;
    public float attackRange;
}
