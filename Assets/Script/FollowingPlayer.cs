using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingPlayer : MonoBehaviour {

	public Transform player;
	private float offset = 0f;

    void Start() {
        NotificationCenter.DefaultCenter().AddObserver(this, "StartRunning");   
    }

    void StartRunning() {
        Invoke("UpdateOffserByOne", 2.0f);
    }

    void UpdateOffserByOne() {
        if (offset <= 6f) {
            offset += 0.01f;

            Invoke("UpdateOffserByOne", 0.03f);
        } 
    }

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);
    }
}
