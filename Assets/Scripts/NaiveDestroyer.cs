using UnityEngine;
using System.Collections;

public class NaiveDestroyer : MonoBehaviour {

	public float lifeTime = 1;

	float elapsedTime = 0f;
	
	void OnEnable () {
		elapsedTime = 0f;
	}

	void Update () {
		if (elapsedTime >= lifeTime) {
			Destroy(gameObject);
		}
		elapsedTime += Time.deltaTime;
	}
}
