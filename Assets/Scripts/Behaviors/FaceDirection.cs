using UnityEngine;
using System.Collections;

public class FaceDirection : AbstractBehavior {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var right = inputState.GetButtonValue (inputButtons [0]);
		var left = inputState.GetButtonValue (inputButtons [1]);
        var up = inputState.GetButtonValue(inputButtons[2]);
        var down = inputState.GetButtonValue(inputButtons[3]);

        if (right) {
			inputState.direction = Directions.Right;
		} else if (left) {
			inputState.direction = Directions.Left;
		}

        if (up)
        {
            inputState.headings = Headings.Up;
        }
        else if (down)
        {
            inputState.headings = Headings.Down;
        }

		transform.localScale = new Vector3 ((float)inputState.direction, 1, 1);
	}
}
