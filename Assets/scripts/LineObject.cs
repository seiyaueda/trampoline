using UnityEngine;
using System.Collections;

public class LineObject : MonoBehaviour {
	Vector3 startPressPosition;
	Vector3 endPressPosition;
	Vector3 nowPressPosition;
	Vector3 distVector; 

	LineRenderer lineRenderer;
	public bool isPressed;
	private Renderer rend;

	GameObject GameManager;
	GameManagerScript GMScript;

	EdgeCollider2D edgeCollider;

	//public AudioSource chalk;                              //ここと

	// Use this for initialization
	void Start () {

		//chalk = GetComponent<AudioSource>();               //ここと
		lineRenderer = this.GetComponent<LineRenderer>();
		rend = this.GetComponent<Renderer>();
		lineRenderer.SetVertexCount(2);
		lineRenderer.enabled = false;
		startPressPosition = transform.position;
		lineRenderer.SetPosition(0,transform.position);

		edgeCollider = this.GetComponent<EdgeCollider2D>();

		isPressed = true;
		//線の表示秒数
		Destroy(gameObject, 15.0f);
		//GameManagerScript = GameManager.GetComponent<GameManagerScript>();

		GameManager = GameObject.Find("GameManager");
		GMScript = GameManager.GetComponent<GameManagerScript>();
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton(0) && isPressed){
			//chalk.Play ();                                   //ここ
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,9.9f);
			nowPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);

			// 線の長さを測る
			distVector = nowPressPosition - transform.position;
			float lengthLine = distVector.magnitude;

			float distance =  Vector3.Distance(nowPressPosition,startPressPosition);

			// 線の長さが最大値より大きかったら、線の長さを最大値までの長さにする。
//			if (lengthLine > GetComponent<GameManager>(GameManagerScript)) {
//				nowPressPosition = transform.position + maxLength * distVector.normalized;	
//			}
			lineRenderer.SetPosition(1,nowPressPosition);
			lineRenderer.material.SetFloat("_RepeatCount",distance);
			lineRenderer.enabled = true;

			DottedLine();

			Vector2 tempColposition = (Vector2)nowPressPosition - (Vector2)transform.position;
			edgeCollider.points = new Vector2[] {new Vector2(0, 0), tempColposition};
		}

//		GMScript.TestDebug();


		if(Input.GetMouseButtonUp(0)){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,9.9f );
			endPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);

			//Debug.Log(endPressPosition);
			isPressed = false;

		}
			

	}
	void DottedLine(){
		float distance = Vector3.Distance(nowPressPosition,startPressPosition);
		rend.material.mainTextureScale = new Vector2(distance, 1);
	}

	void OnDestroy(){
		GMScript.IncreaseLineCount();
	}

}