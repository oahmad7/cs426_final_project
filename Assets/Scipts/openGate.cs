using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGate : MonoBehaviour
{
    public GameObject Gate;
    public AudioSource doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Gate.SetActive(false);
        doorOpen.Play();
        Destroy(gameObject);
    }
}
