using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	public GameObject player;
	float timer;

	// Use this for initialization
	void Start () {
		timer = 5.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0){
			timer = 5.0f;
		Vector3 playerPosition = new Vector3(-2.5f, 1.8f, 0.0f);
		Instantiate (player, playerPosition, Quaternion.identity);
		}
	}
}
