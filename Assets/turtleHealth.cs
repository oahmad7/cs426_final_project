using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtleHealth : MonoBehaviour
{
    public int health = 3;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
        else
        {
            health = health - 1;
        }
    }
}
