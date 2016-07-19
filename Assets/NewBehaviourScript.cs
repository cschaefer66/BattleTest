using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.left*10f*Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-Vector3.left*10f*Time.deltaTime);
        }
	}
}
