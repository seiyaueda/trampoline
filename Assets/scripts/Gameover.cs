using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gameover : MonoBehaviour {
	private int HighScore;
	private string key = "HIGH SCORE";
	public Text HighScoreText;
	public GameObject Score;
	public GameObject ScoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HighScore = PlayerPrefs.GetInt(key, 0);
		HighScoreText.text = "HighScore: " + HighScore.ToString();
		Score.GetComponent<Text>().text = ScoreText.GetComponent<Text>().text;
	}
}
