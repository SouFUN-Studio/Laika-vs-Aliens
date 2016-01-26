using UnityEngine;
using System.Collections;

public class StopRotation : MonoBehaviour {
	public float tilt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
	}
}
