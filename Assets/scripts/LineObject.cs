using UnityEngine;
using System.Collections;

public class LineObject : MonoBehaviour {
	Vector3 endPressPosition;
	Vector3 nowPressPosition;
	
	LineRenderer lineRenderer;
	public bool isPressed;

	EdgeCollider2D edgeCollider;
	
	// Use this for initialization
	void Start () {
		lineRenderer = this.GetComponent<LineRenderer>();
		lineRenderer.SetVertexCount(2);
		lineRenderer.enabled = false;
		lineRenderer.SetPosition(0,transform.position);

		edgeCollider = this.GetComponent<EdgeCollider2D>();
		
		isPressed = true;

		//Destroy(gameObject, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(0) && isPressed){
			Vector3 tempPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,9.9f);
			nowPressPosition = Camera.main.ScreenToWorldPoint(tempPosition);
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
