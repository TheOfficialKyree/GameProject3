using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnManager : MonoBehaviour
{
   // public static ObjectSpawnManager instance;
    

   // private void Awake()
   // {
    //   if (instance == null)
   //    {
    //      instance = this;
    //   }
  //  }

  //  public void SpawnObjects(Collider spawnableAreaCollider, GameObject[] objects)
   // {
    //   foreach(GameObject object in objects)
    //   {
   //      Vector3 spawnPosition = GetRandomSpawnPosition(spawnableAreaCollider)
   //      GameObject spawnedObject = Instantiate(object, spawnPosition, Quaternion.identity);
   //    }
 //   }


   // private Vector3 GetRandomSpawnPosition(Collider spawnableAreaCollider)
   // {
   //    Vector3 spawnPosition = Vector3.zero;
   //    bool isSpawnPosValid = false;

    //   int attemptCount = 0;
    //   int maxAttempts = 10;

    //   int layerToNotSpawnOn = LayerMask.NameToLayer("Wall");

   //    while(!isSpawnPosValid && attemptCount < maxAttempts)
  //     {
  //        spawnPosition = GetRandomPointInCollider(spawnableAreaCollider);
   //       Collider[] colliders = Physics.OverLapCircleAll(spawnPosition, 2f);
  //     }

   //    bool isInvalidCollision = false;
  //     foreach (Collider collider in colliders)
   //    {
  //         if (collider.gameObject.layer == layerToNotSpawnOn)
   //        {
  //            isInvalidCollision = true;
    //          break;
   //        }
   //    }

    //   if(!isInvalidCollision)
    //   {
    //     isSpawnPosValid = true;
    //   }
       
   //    attemptCount++;

   //    if(!isSpawnPosValid)
   //    {
   //      Debug.LogWarning("Could not find a valid position");
   //    }

   //    return spawnPosition;
   //  }
   // private Vector3 GetRandomPointInCollider(Collider collider, float offset = 1f);
   // {
   //    Bounds collBounds = collider.bounds;

   //    Vector3 minBounds = new Vector3(collBounds.min.x + offset, collBounds.min.y + offset, collBounds.min.z + offset);
   //    Vector3 maxBounds = new Vector3(collBounds.min.x - offset, collBounds.min.y - offset, collBounds.min.z - offset);

    //   float randomX = Random.Range(minBounds.x , minBounds.y, minBounds.z);
   //    float randomY = Random.Range(minBounds.y, minBounds.z, minBounds.x);
  //     float randomZ = Random.Range(minBounds.z, minBounds.x, maxBounds.y);

  //     return new Vector3(randomX, randomY, randomZ);
   // }


} 

