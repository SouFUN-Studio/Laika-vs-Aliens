using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
	public int hp;
	private int damage;
	void OnTriggerEnter(Collider other) {

		if (other.tag == "Boundary" || other.tag == "MainCamera" || other.tag == "Player") {
			return;
		}
		damage++;

		Destroy (other.gameObject);
		if (damage == hp) {
			Destroy (gameObject);
		}
	}
}
