using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : AbstractBehavior
{
    public bool isAttacking = false;

    protected virtual void Update()
    {
        isAttacking = inputState.GetButtonValue(inputButtons[0]);
    }

}
