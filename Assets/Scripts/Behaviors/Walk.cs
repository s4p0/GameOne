using UnityEngine;
using System.Collections;

public class Walk : AbstractBehavior
{

    public float speed = 50f;
    public float runMultiplier = 2f;
    public bool running;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        running = false;

        var right = inputState.GetButtonValue(inputButtons[0]);
        var left = inputState.GetButtonValue(inputButtons[1]);
        var up = inputState.GetButtonValue(inputButtons[2]);
        var down = inputState.GetButtonValue(inputButtons[3]);

        var horizontalVel = Mathf.Abs(body2d.velocity.x);
        var verticalVel = Mathf.Abs(body2d.velocity.y);

        bool isMovingHorizontally = right || left;
        bool isMovingVertically = up || down;

        if (isMovingHorizontally)
        {
            var velX = speed * (float)inputState.direction;
            body2d.velocity = new Vector2(velX, body2d.velocity.y);
        }
        else
        {
            body2d.velocity = new Vector2(0, body2d.velocity.y);
        }

        if (isMovingVertically)
        {
            var velY = speed * (float)inputState.headings;
            body2d.velocity = new Vector2(body2d.velocity.x, velY);
        }
        else
        {
            body2d.velocity = new Vector2(body2d.velocity.x, 0);
        }




        
    }
}
