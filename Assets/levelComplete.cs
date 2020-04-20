using System.Collections.Generic;
using System.Collections;
using UnityEngine;
//Make sure to add this, or you can't use SceneManager
using UnityEngine.SceneManagement;


public class levelComplete : MonoBehaviour
{
    public AudioSource Complete;


    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Door touched");
        //other.name should equal the root of your Player object
        if (collisionInfo.gameObject.tag == "Player")
        {

            Invoke("Menu", 2f);
            Complete.Play();

            //SceneManager.LoadScene(0);
        }
    }
    void Menu()
    {
        SceneManager.LoadScene(0);
    }
}