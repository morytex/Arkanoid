using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

	private bool isBallActive;
	private Vector3 ballPosition;
	private Vector2 ballInitialForce;
	private Rigidbody2D rb;

	public GameObject playerObject;

	// Use this for initialization
	void Start () {
		ballInitialForce = new Vector2 (100.0f, 300.0f);
		isBallActive = false;
		ballPosition = transform.position;
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") && !isBallActive) {
			rb.AddForce (ballInitialForce);
			isBallActive = true;
		}

		if (!isBallActive && playerObject != null) {
			ballPosition.x = playerObject.transform.position.x;
		}
	}

	void OnCollisionEnter2D (Collision2D c) {
		if (c.gameObject.tag == "DeadEnd") {
			Destroy (this.gameObject);

			SceneManager.LoadScene ("StartScene");
		}
	}
}
