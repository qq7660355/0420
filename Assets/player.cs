using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime*speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1) * Time.deltaTime*speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime*speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime*speed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -5, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 5, 0);
        }
    }
}
