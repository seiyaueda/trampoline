using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	public GameObject player;
	float timer;
	int iLife = 5;
	// Use this for initialization
	void Start () {
		//playerのスポーン秒数
		timer = 1.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < 0){
			//playerのスポーン秒数2
			timer = 0.01f;
			Vector3 playerPosition = new Vector3(-2.5f, 1.8f, 0.0f);//デフォ・・・-2.5f, 1.8f, 0.0f
			Instantiate (player, playerPosition, Quaternion.identity);
		}
		if(player.transform.position.y <= -5){
			Debug.Log(player.transform.position);
			iLife --; 
			//Debug.Log("Gameover");

		}
		if(iLife <= 0){
			Debug.Log("Gameover");
		}

	}
}
