using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Moveplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x< 5f )
            {
                transform.position = transform.position + new Vector3(5f, 0, 0);
            }//end if 

        }


        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -5f)
            {
                transform.position = transform.position + new Vector3(-5f, 0, 0);
            }//end if
        }//end if else 

        
    }

    // this function to handel the collide of the player 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="obstcal")
            SceneManager.LoadScene("S1");
    }
}
