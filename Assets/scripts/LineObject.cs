using UnityEngine;
using System.Collections;

public class LineObject : MonoBehaviour {
	Vector3 endPressPosition;
	Vector3 nowPressPosition;

	Vector3 distVector; 
	float maxLength = 3.5f;

	LineRenderer lineRenderer;
	public bool isPressed;

	EdgeCollider2D edgeCollider;

	//public AudioSource chalk;                              //ここと

	// Use this for initialization
	void Start () {
		//chalk = GetComponent<AudioSource>();               //ここと
		lineRenderer = this.GetComponent<LineRenderer>();
		lineRenderer.SetVertexCount(2);
		lineRenderer.enabled = false;
		lineRenderer.SetPosition(0,transform.position);

		edgeCollider = this.GetComponent<EdgeCollider2D>();

		isPressed = true;
		//線の表示秒数
		Destroy(gameObject, 15.0f);
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

			// 線の長さが最大値より大きかったら、線の長さを最大値までの長さにする。
			if (lengthLine > maxLength) {
				nowPressPosition = transform.position + maxLength * distVector.normalized;	
			}
			lineRenderer.SetPosition(1,nowPressPosition);
			lineRenderer.enabled = true;

			Vector2 tempColposition = (Vector2)nowPressPosition - (Vector2)transform.position;
			edgeCollider.points = new Vector2[] {new Vector2(0, 0), tempColposition};
		}

		if(Input.GetMouseButtonUp(0)){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,9.9f );
			endPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);

			//Debug.Log(endPressPosition);
			isPressed = false;

		}



	}
}