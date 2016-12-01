using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	public float coinMoveRate = .2f;
	public AudioClip coinSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector2 (transform.position.x - coinMoveRate, transform.position.y);

		if (transform.position.x <= -15) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Player") {
			AudioSource.PlayClipAtPoint(coinSound, transform.position);
			Destroy (gameObject);
		}
	}
}
