using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelComplete : MonoBehaviour
{
    public AudioSource complete;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {

            complete.Play();

        }

    }
}
