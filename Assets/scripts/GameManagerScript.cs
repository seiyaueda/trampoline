using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameManagerScript : MonoBehaviour {
	GameObject[] playerObjects;
	int playerNum;
	int iLife = 5;
	public GameObject zanki1;
	public GameObject zanki2;
	public GameObject zanki3;
	public GameObject zanki4;
	public GameObject zanki5;
	public GameObject GameoverText;
	public GameObject Spawner;

	int Thewold = 1;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		playerObjects = GameObject.FindGameObjectsWithTag ("mario");
		playerNum = playerObjects.Length;
		//Debug.Log(playerNum);

		if (Thewold == -1){
			//TheWold = 1;
			//Debug.Log("stop");
			Time.timeScale = 0.0F;
		}else if(Thewold == 1){
			Time.timeScale = 1.0F;
		}

	}

	//残機
	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "mario"){
			iLife --;
			Destroy(col.gameObject);

		}
		//残機表示
		if(iLife == 4){
			Destroy(zanki5);
		}
		//ユニティちゃんかわいいいいいいいいいいいいいいいいいい
		if(iLife == 3){
			Destroy(zanki4);
		}
		if(iLife == 2){
			Destroy(zanki3);
		}
		if(iLife == 1){
			Destroy(zanki2);
		}
//		if(iLife == 0){
//			Destroy(Spawner);
////			Time.timeScale = 0.0F;
//			Destroy(zanki1);
//			Debug.Log("Gameover");
//			GameoverText.GetComponent<Text>().text = "Gameover";
//			SceneManager.LoadScene ("GameoverScene");
//
//		}

	}

	public void ButtonPush () {
		//Time.timeScale = 0.0F;
		Thewold = Thewold * -1;
		Debug.Log(Thewold);
	}

}
	
	

