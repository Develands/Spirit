using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollParallax : MonoBehaviour {

	public float velocidad = 0f;
	private bool isMoving = false;
	private float tiempoInicio = 0f;
	private Renderer renderer;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "StartRunning");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");

		renderer = GetComponent<Renderer>();
	}

	void PersonajeHaMuerto(){
		isMoving = false;
	}

	void StartRunning(){
		isMoving = true;
		tiempoInicio = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(isMoving){
			float offsetX = ((Time.time - tiempoInicio) * velocidad) % 1;

			renderer.material.mainTextureOffset = new Vector2(offsetX, 0);
		}
	}
    
}
