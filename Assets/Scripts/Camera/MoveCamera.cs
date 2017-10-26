using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public float speed = 4f;

	private Vector3 startPos;
	private bool moving;

	public GameObject target;

	public float horizontalTol;
	public float verticalTol;

	private bool needToUpdate;

	void Update(){
		var pos = target.transform.position;
		pos.z = Camera.main.transform.position.z;

		var absX = Mathf.Abs (pos.x - Camera.main.transform.position.x);
		var absY = Mathf.Abs (pos.y - Camera.main.transform.position.y);

		needToUpdate = absX > horizontalTol || absY > verticalTol;
	}


	void FixedUpdate(){

		if (target != null) {
			var pos = target.transform.position;
			pos.z = Camera.main.transform.position.z;

			var absX = Mathf.Abs (pos.x - Camera.main.transform.position.x);
			var absY = Mathf.Abs (pos.y - Camera.main.transform.position.y);

			if (absX > horizontalTol || absY > verticalTol)
				Camera.main.transform.position = pos;
		}

		/*
		if (Input.GetMouseButtonDown (1)) {
			startPos = Input.mousePosition;
			moving = true;
		}

		if (Input.GetMouseButtonUp (1) && moving) {
			moving = false;
		}

		if (moving) {
			Vector3 pos = Camera.main.ScreenToViewportPoint (Input.mousePosition - startPos);
			Vector3 move = new Vector3 (pos.x * speed, pos.y * speed, 0);
			transform.Translate (move, Space.Self);
		}*/
	}

}
