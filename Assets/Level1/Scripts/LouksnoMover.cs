using UnityEngine;
using System.Collections;

public class LouksnoMover : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.up * speed;
		//rb.velocity = transform.forward * speed;
	}
	
}
