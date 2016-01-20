using UnityEngine;
using System.Collections;

public class Move_Box : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;
    private bool moved = false;
    private bool back  = false;
    

    void Start()
    {
       rb=GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moved = true;
        }
        if (moved == true)
        {
            rb.velocity = new Vector3(speed, 0.0f, 0.0f);
        }
        if (moved == true && rb.position.x >= 12.01)
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            moved = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            back = true;
        }
        if (back == true)
        {
            rb.velocity = new Vector3(-speed, 0.0f, 0.0f);
        }
        if (back == true && rb.position.x <= 0)
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            back = false;
        }

    }
}