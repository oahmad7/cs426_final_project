using System.Collections.Generic;
using System.Collections;
using UnityEngine;
//Make sure to add this, or you can't use SceneManager
using UnityEngine.SceneManagement;


public class levelComplete : MonoBehaviour
{

    void OnTriggerEnter(Collider collisionInfo)
    {
        //other.name should equal the root of your Player object
       if (collisionInfo.collider.tag == "Player")
        {

      Debug.Log("Door touched");
           SceneManager.LoadScene(0);
        }
    }
}