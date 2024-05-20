//Orpheus' Music notes used to attack monsters
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class limited_defenseNotes : MonoBehaviour
{
    public float Speed = 4.5f;
    public int numNotes = 0;
    public int maxNotes = 100;
    public GameObject note;

    public Transform LaunchOFFset;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (note == null)
            {
                Debug.Log("No Music!");
            }

            else
            {


                if (numNotes > 0)
                {
                    Debug.Log("+1");
                    Instantiate(note, LaunchOFFset.position, transform.rotation);
                    numNotes--;
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "attackPoint" && (numNotes < maxNotes))
        {
            Debug.Log("+10");
            numNotes = numNotes + 10;
        }



    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("attackPoint") && numNotes < maxNotes)
        {
            numNotes = numNotes + 10;

        }
    }*/
}