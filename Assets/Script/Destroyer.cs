using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			Debug.Break();
			// POR HACER... HACER QUE SE MUESTRE LA PUNTUACION MAXIMA
			// (HA MUERTO EL PERSONAJE)
			Debug.Break();
		}else{
			Destroy(other.gameObject);
		}
	}
}
