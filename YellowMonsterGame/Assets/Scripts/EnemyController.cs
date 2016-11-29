using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float batMoveRate = .2f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector2 (transform.position.x - batMoveRate, transform.position.y);

		if (transform.position.x <= -15) {
			transform.position = new Vector2 (Random.Range(15,25), Random.Range(-4, 4));
		}
	}
}
