using UnityEngine;
using System.Collections;

public class NaiveSpawner : MonoBehaviour {

	public Transform cubePrefab;
	public Transform sphereSpawnerPosition;
	public float sphereRadius;
	public float timeBetweenSpawns = 1;
	public float numSpawns = 10;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnCubes ());
	}

	IEnumerator SpawnCubes() {
		while (true) {
			for (int i = 0; i < numSpawns; i++) {
				RandomSpawn();
			}
			yield return new WaitForSeconds(timeBetweenSpawns);
		}
	}

	void RandomSpawn() {
		Transform newInstance;
		newInstance = Instantiate (cubePrefab, Random.onUnitSphere * sphereRadius, Random.rotation) as Transform;
		MeshRenderer renderer = newInstance.GetComponent<MeshRenderer> ();
		if (renderer) {
			renderer.material.color = new Color (Random.value, Random.value, Random.value);
		}
	}


}
