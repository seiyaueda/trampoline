using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class ReStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown("r")){
		if (Input.GetKeyDown(KeyCode.R)){
			Debug.Log("せいこう");
			SceneManager.LoadScene ("Trampoline");

		}
	
	}
	public void ButtonPush () {
		SceneManager.LoadScene ("Trampoline");
	}
}
