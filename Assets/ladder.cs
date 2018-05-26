using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    public GameObject player;
    public bool collided;
    // Use this for initialization
    void Start () {
        rb = player.GetComponent<Rigidbody>();
    }


    public void OnCollisionEnter()
    {
        collided = true;
    }

    public void OnCollisionExit()
    {
        collided = false;
    }

    // Update is called once per frame
    void Update () { 
        if (collided == true && Input.GetKey(KeyCode.UpArrow) == true)
        {
                Vector3 movement = new Vector3(0.0f, 10.0f, 0.0f);
                rb.AddForce(movement * speed);

               

        }
        else if (collided == true && Input.GetKey(KeyCode.DownArrow) == true)
        {
                Vector3 movement = new Vector3(0.0f, -10.0f, 0.0f);
                rb.AddForce(movement * speed);

               

        }        

    }
}


