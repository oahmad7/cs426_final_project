using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 25.0f;
    public float rotationSpeed = 45;
    public float force = 700f;
    public GameObject cannon;
    public GameObject wind;
    public GameObject bullet;
    public int counter = 0;
    public AudioSource fire;
    public AudioSource windSound;
    public AudioSource Death;

    Rigidbody rb;
    Transform t;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.velocity += this.transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.A))
            t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.C))
            if (counter == 0)
            {
                counter = 1;

            }
            else
            {
                counter = 0;
            }


        if (Input.GetButtonDown("Fire1"))
        {
            if (counter == 0)
            {
                GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
                newBullet.AddComponent<Rigidbody>();
                newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 10;
                newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
                fire.Play();
            
            }
            if( counter == 1)
            {
                GameObject newBullet = GameObject.Instantiate(wind, cannon.transform.position, cannon.transform.rotation) as GameObject;
                newBullet.AddComponent<Rigidbody>();
                newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 10;
                newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
                windSound.Play();
            }
        }
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            
            FindObjectOfType<GameManager>().EndGame();
            Death.Play();

        }

    }
}
