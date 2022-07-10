using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject nemesisObject;
    public GameObject mrxobject;
    void Spawn()
    {

        GameObject spawnobject;
        int choice = Random.Range(0,2);

        if (choice == 1)
            spawnobject = nemesisObject;
        else
            spawnobject = mrxobject;
        //////////////////
        int newp = Random.RandomRange(-1,2);
        Vector3 Vp = transform.position;
        Vp.x = Vp.x +( 5 * newp);


        //GameObject newSpawn = Instantiate(spawnobject,Vp ,Quaternion.identity); 
        GameObject newSpawn = Instantiate(spawnobject);
        newSpawn.transform.position = Vp;
    
    }


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
