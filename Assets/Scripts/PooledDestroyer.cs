using UnityEngine;
using System.Collections;

public class PooledDestroyer : MonoBehaviour {

	public float lifeTime = 1f;

	void OnEnable() {
		TrashMan.despawnAfterDelay (gameObject, lifeTime);
	}
}
