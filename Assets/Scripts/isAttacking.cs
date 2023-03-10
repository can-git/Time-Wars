using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isAttacking : MonoBehaviour
{
    GameObject currentTarget;

    void Update()
    {
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }
  
    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget)
        {
            return;
        }
        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            GetComponent<AudioSource>().Play();
            health.DealDamage(damage);
        }
    }
}
