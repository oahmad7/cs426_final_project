using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_Slimes : MonoBehaviour
{
    public GameObject Slime1;


    void OnCollisionEnter(Collision collision)
    {
        Slime1.SetActive(false);
 
        Destroy(gameObject);
    }
}
