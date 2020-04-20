using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory_tree : MonoBehaviour
{
    public GameObject PowerUp;
    public AudioSource puzzelSound;

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Tree touched");
        //other.name should equal the root of your Player object
        if (collisionInfo.gameObject.tag == "Fire")
        {

            Destroy(gameObject);
            PowerUp.SetActive(true);
            puzzelSound.Play();
        }
    }
}
