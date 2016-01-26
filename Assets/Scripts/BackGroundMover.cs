using UnityEngine;
using System.Collections;

public class BackGroundMover : MonoBehaviour {
	private bool isOnSelectLevel = false;

	public GameObject background;

	public void onMouseDown(){
		if (isOnSelectLevel == false) {
			background = GameObject.Find ("Background");
			background.GetComponent<Animation> ().Play ("ScrollRight");
			isOnSelectLevel = true;
		} else {
			background = GameObject.Find ("Background");
			background.GetComponent<Animation> ().Play ("ScrollLeft");
			isOnSelectLevel = false;
		}
	}
}
