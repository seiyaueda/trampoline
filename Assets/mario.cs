using UnityEngine;
using System.Collections;

public class mario : MonoBehaviour {
	public float jamp;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		rb.AddForce(100f,200f,0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
