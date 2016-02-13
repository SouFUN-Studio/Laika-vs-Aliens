using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.right * speed;
	}

}
