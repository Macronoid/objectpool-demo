using UnityEngine;
using System.Collections;

public class PooledSpawner : MonoBehaviour {

	public GameObject cubePrefab;
	public Transform sphereSpawnerPosition;
	public float sphereRadius;
	public float timeBetweenSpawns = 1;
	public float numSpawns = 10;

    void Awake()
    {
        
    }

	// Use this for initialization
	void Start () {
        TrashManRecycleBin recycleBin = new TrashManRecycleBin()
        {
            prefab = cubePrefab
        };
        TrashMan.manageRecycleBin(recycleBin);
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
		GameObject newInstance;
		newInstance = TrashMan.spawn (cubePrefab, Random.onUnitSphere * sphereRadius, Random.rotation) as GameObject;
		MeshRenderer renderer = newInstance.GetComponent<MeshRenderer> ();
		if (renderer) {
			renderer.material.color = new Color (Random.value, Random.value, Random.value);
		}
	}

}
