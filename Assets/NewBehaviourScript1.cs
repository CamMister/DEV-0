using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
    public float moveSpeed;
	// Use this for initialization
	void Start () {
        moveSpeed = 25f;
	}
	
	// Update is called once per frame
	void Update () {
        Input.GetAxis("Horizontal");
        transform.Translate(moveSpeed * Input.GetAxis("Vertical")* Time.deltaTime, moveSpeed * Input.GetAxis("Horizontal") , 0f);

    }
}
