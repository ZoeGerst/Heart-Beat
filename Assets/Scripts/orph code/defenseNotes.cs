//Orpheus' Music notes used to attack monsters
using UnityEngine;

public class defenseNotes : MonoBehaviour
{
    public float Speed = 4.5f; 

    // Update is called once per frame
    public void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * Speed;
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "boss")
           {
            Destroy(gameObject);
           }
    }
}