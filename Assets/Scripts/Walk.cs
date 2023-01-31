using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    float speed = 0.6f;

    void Start() {
        if(this.tag == "Hero"){
            speed = GetComponent<Hero>().GetCurrentSpeed();
        }
        else if(this.tag == "Attacker"){
            speed = GetComponent<Enemy>().GetCurrentSpeed();
        }
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    public void MoveTo(float walkSpeed)
    {
        speed = walkSpeed;
    }
}
