using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	/*public GameObject goalObject;
	int score;
	public GameObject ScoreText;*/
	public float jamp;
	public Rigidbody2D rb;
	Vector2 jumpVec;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		jumpVec = new Vector2(100f,100f);

		rb.AddForce(jumpVec);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y <= -5){
			
			//Debug.Log("Gameover");
			Destroy(gameObject);

		}


			
	
	}

	/*void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "Goal"){
			Debug.Log("Goal");
			score += 100;
			Debug.Log(score);
			ScoreText.GetComponent<Text>().text = score.ToString();
			//Destroy(collision.gameObject);
			//Vector3 goalPosition = new Vector3(Random.Range(-2,2), Random.Range(-2,2), 0);
			//Instantiate(goalObject, goalPosition, Quaternion.identity);
		}
	}*/
}
