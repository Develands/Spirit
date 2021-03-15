using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour {
    
	public CharacterController2D controller;

	public TextMeshPro score;

	public float horizontalMove = 0f;

	public Animator animator;

	private bool isRunnig = false;

	// float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	bool isJump = false;

	// Update is called once per frame
	void Update () {

		int xPos = (int)transform.position.x;

		if (xPos > 0) {
			PlayerPrefs.SetInt("score", xPos);
		
			score.text = xPos.ToString() + " m";
		}
		
		if (Input.GetMouseButtonDown(0)) {

			if (isRunnig == false) {

				isRunnig = true;

				NotificationCenter.DefaultCenter().PostNotification(this, "StartRunning");

				horizontalMove = 60f;

				animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
			}
		}
	

		if (!isJump) {
			if (Input.GetMouseButtonDown(0)) {
				jump = true;

				isJump = true;

				if (horizontalMove < 115) {
					horizontalMove += 1;
				}

				animator.SetBool("IsJumping", true);
			}
		}
	}

	public void OnLanding() {
		//isJump = false;

		animator.SetBool("IsJumping", false);

		Invoke("IsJumpingToFalse", 0.35f);
	}

	void IsJumpingToFalse() {
		isJump = false;
	}

	void FixedUpdate () {
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}


}
