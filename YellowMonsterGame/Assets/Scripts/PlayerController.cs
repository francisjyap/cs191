using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveRate = 0.2f;
	public bool isDead = false;
	public float lowerBound = -4f;
	public float upperBound = 4f;
	public float leftBound = -8.5f;
	public float rightBound = 8.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isDead == false) {
			float moveX = Input.GetAxis("Horizontal");
			float moveY = Input.GetAxis ("Vertical");

			transform.position = new Vector2 (transform.position.x + moveX, transform.position.y + moveY);

			if (transform.position.y >= upperBound) {
				transform.position = new Vector2 (transform.position.x, upperBound);
			}
			if (transform.position.y <= lowerBound) {
				transform.position = new Vector2 (transform.position.x, lowerBound);
			}
			if (transform.position.x <= leftBound) {
				transform.position = new Vector2 (leftBound, transform.position.y);
			}
			if (transform.position.x >= rightBound) {
				transform.position = new Vector2 (rightBound, transform.position.y);
			}
		}
	}
}
