using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float batMoveRate = .2f;


	// Use this for initialization
	void Start () {
		batMoveRate = Random.Range (.2f, .4f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector2 (transform.position.x - batMoveRate, transform.position.y);

		if (transform.position.x <= -15) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Player") {
			Destroy (target.gameObject);
		}
	}
}
