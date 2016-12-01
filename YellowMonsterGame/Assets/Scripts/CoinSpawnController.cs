using UnityEngine;
using System.Collections;

public class CoinSpawnController : MonoBehaviour {

	public Transform coinPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating("GenerateCoin", 0, 2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GenerateCoin() {
		Instantiate(coinPrefab,new Vector2(Random.Range(11,15), Random.Range(-4, 4)), coinPrefab.rotation);
	}

}
