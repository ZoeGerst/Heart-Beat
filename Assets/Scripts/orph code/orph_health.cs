using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class orph_health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currHealth;
    public health_bar healthBar;

    // public float Speed = 4.5f;
    //  public static int numNotes;
    //   public static int maxNotes = 100;
    // public GameObject note;



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
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        /*else if (other.gameObject.tag == "attackPoint" && numNotes < maxNotes)
        {
            numNotes = numNotes + 10;
        }*/

    }
    void update()
    {
        if (currHealth <= 0)
        {
            Debug.Log("trigger");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        /*  if (Input.GetKeyDown("space"))
          {

              if (notes== null)
              {
                  Debug.Log("No Music!");
              }

              else
              {


                  if (numNotes > 0)
                  {
                      Debug.Log("+1");
                      numNotes--;
                  }
              }
          }*/
    }

}