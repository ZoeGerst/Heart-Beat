using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour


{
     
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //float moveSpeed = 50;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
       {
           transform.position += new Vector3(0, 0, 2); 
        }
       if (Input.GetKeyUp("d"))
        {
            transform.position += new Vector3(0, 0, -2);
        }










      
       { if (Input.GetKeyDown("a"))
        {
           transform.position += new Vector3(0, 0, -2); 
        }
       if (Input.GetKeyUp("a"))
        {
            transform.position += new Vector3(0, 0, 2);
        }
        }
    }
}
