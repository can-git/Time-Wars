using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ScriptableEnemy enemy;
    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Defender>())
        {
            if(GetIsAttacker()){
                GetComponent<isAttacking>().Attack(otherObject);
            }
            else if(!GetIsAttacker()){
                GetComponent<ShooterEnemy>().StopWalking();
            }
            
        }
    }

    public float GetHealth(){
        return enemy.health;
    }
    public float GetCurrentSpeed(){
        return enemy.currentSpeed;
    }
    public bool GetIsAttacker(){
        return enemy.isAttacker;
    }
}
