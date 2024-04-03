using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    Rigidbody rb;
    //private int Massa_Ganho_Perda = 0;
    public  float Jump = 50;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up*Jump,ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            aumentarmassa();
        }

        if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            diminuirmassa();
        }
        
    }

    void aumentarmassa()
    {
        rb.mass += 0.5f;
    }
    void diminuirmassa()
    {
        if(rb.mass > 0.5f)
        {
            rb.mass -= 0.1f;
        }
    }
    
}
