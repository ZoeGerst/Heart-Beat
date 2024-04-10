using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orph_health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currHealth;
    public health_bar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
        healthBar.SetHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //put in trigger
    }
}
