using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodge : MonoBehaviour
{
    private SpriteRenderer thSR;
    public Sprite uprightOrph;
    public Sprite dodgeLeft;
    public Sprite dodgeRight;

    public KeyCode keyPressedLeft;
    public KeyCode keyPressedRight;

    public defenseNotes orph_attack;
    public Transform LaunchOFFset;
    // Start is called before the first frame update
    void Start()
    {
        thSR = GetComponent<SpriteRenderer>();
        thSR.sprite = uprightOrph;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyPressedLeft))
        {

            thSR.sprite = dodgeLeft;

        }
        if (Input.GetKeyDown(keyPressedRight))
        {

            thSR.sprite = dodgeRight;

        }
        if (Input.GetKeyUp(keyPressedLeft))
        {

            thSR.sprite = uprightOrph;

        }
        if (Input.GetKeyUp(keyPressedRight))
        {

            thSR.sprite = uprightOrph;

        }
        //if (Input.GetKeyDown(KeyCode.Space))
       // {

          //  Instantiate(orph_attack, LaunchOFFset.position, transform.rotation);

        //}



    }
}