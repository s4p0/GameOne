using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	private InputState inputState;
	private Walk walkBehavior;
	private Animator animator;
	private CollisionState collisionState;
	private Duck duckBehavior;
    private Attack attack;

	void Awake(){
		inputState = GetComponent<InputState> ();
		walkBehavior = GetComponent<Walk> ();
		animator = GetComponent<Animator> ();
		collisionState = GetComponent<CollisionState> ();
		duckBehavior = GetComponent<Duck> ();
        attack = GetComponent<Attack>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //if (collisionState.standing) {
        //	ChangeAnimationState(0);
        //}

        if(attack.isAttacking)
        {
            ChangeAnimationState(3);
        }
        else if (inputState.absVelX > 0 || inputState.absVelY > 0)
        {
            ChangeAnimationState(2);
        }
        else
        {
            ChangeAnimationState(0);
        }

        //if (inputState.absVelY > 0) {
        //	ChangeAnimationState(2);
        //}

        //animator.speed = walkBehavior.running ? walkBehavior.runMultiplier : 1;

        //if (duckBehavior.ducking) {
        //	ChangeAnimationState(3);
        //}

        //if (!collisionState.standing && collisionState.onWall) {
        //	ChangeAnimationState(4);
        //}
    }

	void ChangeAnimationState(int value){
        animator.SetInteger("PlayerState", value);
    }
}
