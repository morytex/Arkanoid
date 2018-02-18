using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlinkScript : MonoBehaviour {

	public float intervalo;

	// Use this for initialization
	IEnumerator Start () {
		GetComponent<SpriteRenderer> ().enabled = 
			!GetComponent<SpriteRenderer> ().enabled;
		yield return new WaitForSeconds(intervalo);
		StartCoroutine (Start ());
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			SceneManager.LoadScene ("GameScene");
		}
	}
}
