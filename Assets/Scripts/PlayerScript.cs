using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	public float velocity;

	private float leftWallPosition;
	private float rightWallPosition;
	private float playerHeigth;

	// Use this for initialization
	void Start () {
		leftWallPosition = -6.8f;
		rightWallPosition = 6.9f;
		playerHeigth = -4.37f;
	}

	// Update is called once per frame
	void Update () {
		// Move a barra
		float px = Input.GetAxisRaw ("Horizontal") * velocity * Time.deltaTime;
		transform.Translate (px, 0.0f, 0.0f);
		if (transform.position.x < leftWallPosition) {
			transform.position = new Vector3 (leftWallPosition, playerHeigth, 0.0f);
		}
		if (transform.position.x > rightWallPosition) {
			transform.position = new Vector3 (rightWallPosition, playerHeigth, 0.0f);
		}

		// Verifica se existem blocos na tela
		GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");
		if (blocks.Length <= 0) {
			SceneManager.LoadScene ("StartScene");
		}

	}
}
