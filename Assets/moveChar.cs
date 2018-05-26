using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveChar : MonoBehaviour {
    public float speed;
    public GameObject player;
    public bool collided;

    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "untitled")
        {
            collided = true;
        }
    }

    public void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "untitled")
        {
            collided = false;
        }
    }
 
    // Update is called once per frame
    void Update() {
        Physics.gravity = new Vector3(0, -7.0f, 0);

        if (!collided)
       { 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveHorizontal, 0.0f, -moveVertical);


        rb.AddForce(movement * speed);
   }
        else
        {

        }

    }
}
