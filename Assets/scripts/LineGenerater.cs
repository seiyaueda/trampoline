 using UnityEngine;
using System.Collections;

public class LineGenerater : MonoBehaviour {
	[SerializeField]
	bool isPressed;
	
	Vector3 startPressPosition;
	Vector3 endPressPosition;
	
	public GameObject lineObject;

	GameObject GameManager;
	GameManagerScript GMScript;

	
	// Use this for initialization
	void Start () {
		isPressed =false;
		GameManager = GameObject.Find("GameManager");
		GMScript = GameManager.GetComponent<GameManagerScript>();
		//GMScript.remainLineCount;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,9.9f);
			startPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);

			if(GMScript.remainLineCount > 0){
				Instantiate(lineObject,startPressPosition,Quaternion.identity);
				GMScript.DecreaseLineCount();
			}
			//Debug.Log(startPressPosition);
			
			isPressed = true;
		}
		
		if(Input.GetMouseButton(0)){
			
		}
		
		if(Input.GetMouseButtonUp(0)){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,9.9f );
			endPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);
			
			generateLine();
			
			isPressed = false;
		}
		
	}
	
	//リアルタイムで描画しない場合
	void generateLine(){
		
//		Instantiate
//		enabled = false
//		SetVertexCount = 2
//		setPositions
//		enabled = true
		
		
	}
}
