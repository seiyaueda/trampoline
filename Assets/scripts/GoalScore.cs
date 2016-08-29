using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoalScore : MonoBehaviour {
	public GameObject goal;
	int score;
	int goalScore;
	int goalflag;
	public GameObject ScoreText;
	public Text HighScoreText;

	private int HighScore;
	private string key = "HIGH SCORE";

	// Use this for initialization
	void Start () {
		score = 0;
		HighScore = PlayerPrefs.GetInt(key, 0);
		HighScoreText.text = "HighScore: " + HighScore.ToString();
		//HighScoreText.GetComponent<Text>().text = "HighScore: " + HighScore.ToString();

	}

	// Update is called once per frame
	void Update () {
		if (goalScore >= 1000){
			goalScore = 0;
			goalflag = Random.Range (1, 8);
			if ((goalflag == 1)||(goalflag == 2)){
				goal.transform.position = new Vector3 (2.6f, -2.5f, -1.0f);
			}else if ((goalflag == 3)||(goalflag == 4)){
				goal.transform.position = new Vector3 (-2.6f, -1.5f, -1.0f);
			}else if ((goalflag == 5)||(goalflag == 6)){
				goal.transform.position = new Vector3 (2.6f, 0.5f, -1.0f);
			}else if (goalflag == 7){
				goal.transform.position = new Vector3 (-2.6f, -4.0f, -1.0f);
			} 
		}

	}

	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.tag == "mario"){
			//Debug.Log("Goal");
			score += 100;
			goalScore += 100;
			Debug.Log(score);
			//ScoreText.text = "Score: " + score.ToString();
			ScoreText.GetComponent<Text>().text = "YourScore: " + score.ToString();
			/*Destroy(collision.gameObject);
            Vector3 goalPosition = new Vector3(Random.Range(-2,2), Random.Range(-2,2), 0);
            Instantiate(goalObject, goalPosition, Quaternion.identity);*/

			if (score > HighScore) {
				HighScore = score;
				PlayerPrefs.SetInt(key, HighScore);
				HighScoreText.text = "HighScore : " + HighScore.ToString();
				//HighScoreText.GetComponent<Text>().text = "HighScore: " + HighScore.ToString();
			}
		}


		//score += 100;
		//Debug.Log(score);
		//ScoreText.GetComponent<Text>().text = score.ToString();
		/*Destroy(collision.gameObject);
            Vector3 goalPosition = new Vector3(Random.Range(-2,2), Random.Range(-2,2), 0);
            Instantiate(goalObject, goalPosition, Quaternion.identity);*/
	}

}