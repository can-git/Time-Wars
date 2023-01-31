using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] ScriptableHero hero;
    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Attacker>())
        {
            if(TryGetComponent(out isAttacking hinge)){
                GetComponent<isAttacking>().Attack(otherObject);
            }
        }
    }

    public int GetStarCost(){
        return hero.starCost;
    }
    public float GetHealth(){
        return hero.health;
    }
    public float GetCurrentSpeed(){
        return hero.currentSpeed;
    }
}
