using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour {
    public bool collided;
    public float speed;

    public GameObject player;

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = player.GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            collided = true;
        }
    }
    /**
    public void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            collided = false;
        }
    }
    **/

    // Update is called once per frame
    void Update () {
		if (collided)
        {
            Vector3 movement = new Vector3(5987.0f, 10547.0f, -1068.0f);


            rb.AddForce(movement * speed);
        }
    }
	}

