using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject[] prefab;

	private float distance = 26.85f;

	private float constant = 26.85f;

	void Start() {
		Generator();
	}
	
	public void Generator() {

		Vector3 diff = new Vector3(distance, transform.position.y, transform.position.z);

		GameObject random = prefab[Random.Range(0, prefab.Length)];

		Instantiate(random, diff, Quaternion.identity);

		distance += constant;
	}
    
}
