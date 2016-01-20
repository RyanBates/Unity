using UnityEngine;
using System.Collections;

public class Move_Box : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;
    private bool moved = false;
    private bool back = false;
    

    void Start()
    {
       rb=GetComponent<Rigidbody>();
    }

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moved = true;
        }
        if (moved == true)
        {
            rb.velocity = new Vector3(speed, 0.0f, 0.0f);
        }
        if (moved == true && rb.position.x >= 12.01)
        {
            moved = false;
        }
        if (moved == false)
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }

    }
}