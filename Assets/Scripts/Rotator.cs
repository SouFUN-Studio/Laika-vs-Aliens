﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float spin;
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3 (0, 0, spin)* Time.deltaTime);	
	}
}
