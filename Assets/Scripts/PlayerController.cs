using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]//this make visible the variables of the class in another class
//class that instanciate the variables for the frame of the camera
public class Boundary{
	public float xMin, xMax, yMin, yMax;

}

public class PlayerController : MonoBehaviour {
	//speed and rigidbody of the Laika spaceship
	public float speed;
	public float tilt;
	//make the minimum and maximum of the vaues that can take the ship for doesn't go outside of
	//the camera frame
	public Boundary boundary;
	//instanciate of the basic shoots of laika
	public GameObject shot;
	public Transform shotSpawn;
	
	public float fireRate;
	private float nextFire; 

	void Update(){
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
//			GameObject clone = 
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // as GameObject;

		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		GetComponent<Rigidbody>().velocity = movement * speed;
		
		GetComponent<Rigidbody>().position = new Vector3 (
			Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
			Mathf.Clamp (GetComponent<Rigidbody>().position.y, boundary.yMin, boundary.yMax),
			0.0f
		);
		GetComponent<Rigidbody>().rotation = Quaternion.Euler( 0.0f, 90f, GetComponent<Rigidbody>().velocity.y*-tilt);
	}
}
