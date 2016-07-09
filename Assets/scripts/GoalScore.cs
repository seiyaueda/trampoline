using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoalScore : MonoBehaviour {
	public GameObject PlayerObject;
	int score;
	public GameObject ScoreText;

	// Use this for initialization
	void Start () {
		score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.tag == "mario"){
			Debug.Log("Goal");
			score += 100;
			Debug.Log(score);
			ScoreText.GetComponent<Text>().text = score.ToString();
			/*Destroy(collision.gameObject);
			Vector3 goalPosition = new Vector3(Random.Range(-2,2), Random.Range(-2,2), 0);
			Instantiate(goalObject, goalPosition, Quaternion.identity);*/
		}
		
			
			//score += 100;
			//Debug.Log(score);
			//ScoreText.GetComponent<Text>().text = score.ToString();
			/*Destroy(collision.gameObject);
			Vector3 goalPosition = new Vector3(Random.Range(-2,2), Random.Range(-2,2), 0);
			Instantiate(goalObject, goalPosition, Quaternion.identity);*/
	}
}
