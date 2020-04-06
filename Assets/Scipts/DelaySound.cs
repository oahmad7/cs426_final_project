using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource slime;
    int counter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 150)
        {
            slime.Play();
            counter = 0;
        }
        else
        {
            counter = counter + 1;
        }
    }
}
