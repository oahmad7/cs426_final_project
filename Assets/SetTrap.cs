﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrap : MonoBehaviour
{
    public GameObject Trap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Trap.SetActive(true);
        Destroy(gameObject);
    }
}
