using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EItem", menuName = "Enemy", order = 2)]
public class ScriptableEnemy : ScriptableObject {
    public float health = 100;
    public float currentSpeed = 0.6f;
    public bool isAttacker = true;
}
