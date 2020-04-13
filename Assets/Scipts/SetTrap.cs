using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrap : MonoBehaviour
{
    public GameObject Trap;
    public AudioSource fooled;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Trap.SetActive(true);
        fooled.Play();
        Destroy(gameObject);
    }
}
