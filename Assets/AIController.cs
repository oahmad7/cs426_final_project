using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AIController : MonoBehaviour
{

    public Transform Player;
    public int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 5;
    public int health = 3;
    public AudioSource Attack;
  



    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        //if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        //{

        transform.position += transform.forward * MoveSpeed * Time.deltaTime;



        // if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        //{
        //Here Call any function U want Like Shoot at here or something
        //}

        // }
    }
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
        if (collisionInfo.collider.tag == "Player")
        {


            Attack.Play();

        }
    }
}