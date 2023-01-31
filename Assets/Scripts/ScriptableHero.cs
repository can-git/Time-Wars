using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "HItem", menuName = "Hero", order = 1)]
public class ScriptableHero : ScriptableObject {
    public int starCost = 100;
    public float health = 150;
    public float currentSpeed = 0.6f;
}