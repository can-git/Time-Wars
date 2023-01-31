using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        EffectOnOrClose();
    }
    public void EffectOnOrClose()
    {
        if (gameObject.name != "Enemy2" && gameObject.name != "Enemy5")
        {
            gameObject.GetComponent<AudioSource>().volume = PlayerPrefsController.GetMasterEffectInt();
        }
    }
    void OnDestroy()
    {
        if (FindObjectOfType<KillStarDisplay>())
            FindObjectOfType<KillStarDisplay>().RemoveStars();
    }
}
