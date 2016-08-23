using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 
public class StartScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void ButtonPush () {
		Debug.Log("せいこう");
		SceneManager.LoadScene ("Trampoline");
	}
}
