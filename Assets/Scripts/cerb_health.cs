using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerb_health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currHealth;
    public cerb_health_bar cerbHealthBar;
    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
        cerbHealthBar.CerbSetHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //put in trigger
    }
}
