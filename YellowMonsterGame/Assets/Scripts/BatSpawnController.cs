using UnityEngine;
using System.Collections;

public class BatSpawnController : MonoBehaviour {

	public Transform batPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating("GenerateBat", 0, .8f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}

	void GenerateBat(){
		Instantiate(batPrefab, new Vector2(Random.Range(15,25), Random.Range(-4,4)), batPrefab.rotation);

	}
}
