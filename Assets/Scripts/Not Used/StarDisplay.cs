using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;
    bool work = false;
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }
    public void AddStars(int amount)
    {
        if (work)
        {
            stars += amount;
        }
        
        UpdateDisplay();
    }
    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
    public int GetStars()
    {
        return stars;
    }
    public void WorkorNot(bool workN)
    {
        work = workN;
    }

}
