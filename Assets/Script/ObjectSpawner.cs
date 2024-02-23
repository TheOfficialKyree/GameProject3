using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objects;
   
    public float timeToSpawn;

    private float currentTimeToSpawn;

    public bool isTimer;
    // Start is called before the first frame update
    void Start()
    {
        currentTimeToSpawn = timeToSpawn;
    }

    // Update is called once per frame
    private void UpdateTimer()
    {
        if(currentTimeToSpawn > 0)
        {
          currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
           SpawnObject();
      
            
        }
    }

    public void SpawnObject()
    {
       Instantiate(objects, transform.position, transform.rotation);
    }
    

  
}
