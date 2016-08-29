using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class ReStart : MonoBehaviour {
	//public GameObject ReStartButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown(KeyCode.R)){
//			Debug.Log("せいこう");
//			SceneManager.LoadScene ("Trampoline");
//
//		}
//		if (Input.GetButtonDown(ReStartButton)){
//			SceneManager.LoadScene ("Trampoline");
//		}
//		if (Input.GetButtonDown(BackTitleButton)){
//			SceneManager.LoadScene ("StartScene");
//		}
	
	}
	public void ButtonPush () {
		SceneManager.LoadScene ("Trampoline");
	}
	public void BackTitleButtonPush () {
		SceneManager.LoadScene ("StartScene");
	}
}
