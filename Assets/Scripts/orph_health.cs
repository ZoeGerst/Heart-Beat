using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "damage1")
        {
            currHealth -= (10);
            
            healthBar.SetHealth(currHealth);
            if (currHealth <= 0)
            {
            Debug.Log("trigger");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
    }
    void update ()
    {
         if (currHealth <= 0)
        {
            Debug.Log("trigger");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}