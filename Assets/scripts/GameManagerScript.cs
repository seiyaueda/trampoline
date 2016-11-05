using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using UnityStandardAssets.ImageEffects;

public class GameManagerScript : MonoBehaviour {
	const int MAX_LINE_COUNT = 3;
	public int remainLineCount;
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
	public GameObject Button;
	public GameObject LineController;
	public GameObject ResultCanvas;
	float maxLength = 3.5f;



	int Thewold = 1;
	// Use this for initialization
	void Start () {
		remainLineCount = MAX_LINE_COUNT;
		ResultCanvas.GetComponent<Canvas>().enabled = false;
		Time.timeScale = 1.0F;
	
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
			LineController.GetComponent<LineGenerater>().enabled = false;
		}else if(Thewold == 1){
			Time.timeScale = 1.0F;
			LineController.GetComponent<LineGenerater>().enabled = true;
		}

	}

	public void DecreaseLineCount(){
		remainLineCount --;
		Debug.Log(remainLineCount);
	}
	public void IncreaseLineCount(){
		remainLineCount ++;
		Debug.Log(remainLineCount);
	}
//	public void TestDebug(){
//		Debug.Log("access!");
//	}


	//残機
	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "mario"){
//			iLife --;
			Destroy(col.gameObject);

		}
		//残機表示
		if(iLife == 4){
			Destroy(zanki5);
		}
		if(iLife == 3){
			Destroy(zanki4);
		}
		if(iLife == 2){
			Destroy(zanki3);
		}
		if(iLife == 1){
			Destroy(zanki2);
		}
		if(iLife == 0){	
			Time.timeScale = 0.0F;
			Thewold = -1;
			Destroy(zanki1);
			Camera.main.GetComponent<Blur>().enabled = true;
			Button.GetComponent<Button>().enabled = false;
			ResultCanvas.GetComponent<Canvas>().enabled = true;
			//Button.SetActive(false);
			//GameoverText.GetComponent<Text>().text = "Gameover";
			//Button.GetComponent<Button>().enabled = false;
//			Debug.Log("Gameover");
//			SceneManager.LoadScene ("GameoverScene");
//
		}

	}

	public void ButtonPush () {
		//Time.timeScale = 0.0F;
		Thewold = Thewold * -1;
		Debug.Log(Thewold);

	}

}
	
	

