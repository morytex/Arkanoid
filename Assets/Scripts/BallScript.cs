using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

	private Vector2 ballInitialForce;
	private Rigidbody2D rb;

	public GameObject playerObject;

	// Use this for initialization
	void Start () {
		ballInitialForce = new Vector2 (100.0f, 300.0f);
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (ballInitialForce);
	}

	void OnCollisionEnter2D (Collision2D c) {
		if (c.gameObject.tag == "DeadEnd") {
			Destroy (this.gameObject);

			SceneManager.LoadScene ("StartScene");
		}
	}
}
