using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform AlvoParaSeguir;
    public Vector3 offset;

    private bool SeguirDentro = false;
    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position - AlvoParaSeguir.position;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Alpha1)) 
      {
        SeguirDentro = true;
      }  
        
      if (Input.GetKeyDown(KeyCode.Alpha2))
      {
        SeguirDentro = false;
      }
        

      if (SeguirDentro)
      {
        this.transform.position = AlvoParaSeguir.position;
      }

      else
      {
        this.transform.position = AlvoParaSeguir.position + offset;
      }
    }
}
