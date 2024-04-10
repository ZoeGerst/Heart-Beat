//Orpheus' Music notes used to attack monsters
using UnityEngine;

public class defenseNotes : MonoBehaviour
{
    public float Speed = 4.5f; 

    // Update is called once per frame
    public void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }

    private void onCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
