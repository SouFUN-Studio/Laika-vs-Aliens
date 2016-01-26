using UnityEngine;
using System.Collections;

public class ParticleMover : MonoBehaviour {
	public float speed;
	void Update () {
		transform.Translate (new Vector2 (speed, 0) * Time.deltaTime);	
	}
}
