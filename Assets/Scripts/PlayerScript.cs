using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public float velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float px = Input.GetAxisRaw ("Horizontal") * velocity * Time.deltaTime;

		transform.Translate (px, 0.0f, 0.0f);
	}
}
