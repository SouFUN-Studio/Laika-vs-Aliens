using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazzard;
	public GameObject hazzard2;
	public Vector3 spawnValues;
	public int hazzardCount;
	public int hazzardCount2;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Quaternion spawnRotationLouksno;
	public Quaternion spawnRotationDeimos;

	void Start (){
		StartCoroutine (spawnWaves ());
		Debug.Log ("Termino la rutina");

	}

	IEnumerator spawnWaves () {
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazzardCount; i++) {
				Vector3 spawnPosition = new Vector3 (spawnValues.x, Random.Range (-spawnValues.y, spawnValues.y), spawnValues.z);

				Instantiate (hazzard, spawnPosition, spawnRotationLouksno);
				Instantiate (hazzard2, spawnPosition, spawnRotationDeimos);
				yield return new WaitForSeconds (spawnWait);
			}

			yield return new WaitForSeconds (waveWait);
		}
	}
}
