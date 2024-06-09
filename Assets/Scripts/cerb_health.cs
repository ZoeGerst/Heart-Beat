using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cerb_health : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currCerbHealth;
    public cerb_health_bar cerbHealthBar;
    // Start is called before the first frame update
    void Start()
    {

        currCerbHealth = maxHealth;
        cerbHealthBar.CerbSetHealth(maxHealth);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "damage")
        {
            currCerbHealth -= (10);
            Debug.Log("ouch: " + gameObject.name);
            cerbHealthBar.CerbSetHealth(currCerbHealth);

            if (currCerbHealth <= 1)
            {
                Debug.Log("trigger");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
    }
    void update()
    {
        if (currCerbHealth <= 0)
        {
            Debug.Log("trigger");
        }
    }
}