using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Respawn : MonoBehaviour
{
   private void OnCollisionEnter(Collision Collider)
   {
      if(Collider.gameObject.tag == "Player")
      {
        SceneManager.LoadScene("Level 1");
      }
   }
}
