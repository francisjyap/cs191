using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreGeneratorController : MonoBehaviour {

	public int currScore = 0;
	public int highScore = 0;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("highScore")) {
			highScore = PlayerPrefs.GetInt ("highScore");
		} else
			PlayerPrefs.SetInt ("highScore", 0);
		//GameObject.Find ("highScoreValue").GetComponent<Text> ().text = highScore.ToString ();
	}

	public void AddScore() {
		currScore++;
		if (currScore > highScore)
			PlayerPrefs.SetInt ("highScore", currScore);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GameObject.Find("ScoreValue").GetComponent<Text>().text = currScore.ToString();
		GameObject.Find ("highScoreValue").GetComponent<Text> ().text = PlayerPrefs.GetInt ("highScore").ToString ();
	}
}
