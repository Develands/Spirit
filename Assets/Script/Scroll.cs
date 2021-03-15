using UnityEngine;
//using System.Collections;

public class Scroll : MonoBehaviour {

	public float scrollSpeed = 0f;
	private Vector3 startPosition;
	private float widthTale;

	//private bool enMovimiento = false;
	//private float tiempoInicio = 0f;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "StartRunning");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");

		startPosition = transform.position;
		
		widthTale = transform.localScale.x;

		Debug.Log(startPosition);
	}

	//void PersonajeHaMuerto(){
	//	enMovimiento = false;
	//}

	//void StartRunning(){
	//	enMovimiento = true;
	//	tiempoInicio = Time.time;
	//}
	
	// Update is called once per frame
	void Update () {

		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, widthTale);

		transform.position = startPosition + Vector3.right * newPosition;


		// if(enMovimiento){
		// 	GetComponent<Renderer>().material.mainTextureOffset = new Vector2(((Time.time - tiempoInicio) * velocidad) % 1, 0);
		// }
	}
}
