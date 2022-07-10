using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstcal : MonoBehaviour
{

    Rigidbody rBody;
   public  float speed; 
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        speed = -20f;
        
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector3(0,0,speed);
    }
}
