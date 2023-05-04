using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRandom : StateMachineBehaviour
{
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        animator.SetInteger("ID", Random.Range(0,6));
    }
}
