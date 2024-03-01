using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    [SerializeField] private GameObject[] _objectsToSpawnIn;

    [SerializeField] private Collider _currentRoomSpawnArea;
    private GameObject _player;

    private Collider _coll;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _coll = GetComponent<Collider>();
    }
    
    private void OnTriggerExit(Collider collision)
    {
        //Calculates the exit direction
        if (collision.gameObject == _player)
        {
           Vector3 exitDir = (collision.transform.position - _coll.bounds.center).normalized; 

        
        
        if(exitDir.z > 0)
        {
          //Spawn in objects
          //ObjectSpawnManager.instance.SpawnObjects(_currentRoomSpawnArea, _objectsToSpawnIn);
        }
        }
    }
}
