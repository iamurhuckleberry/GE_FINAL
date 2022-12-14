using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMechine : MonoBehaviour
{
    BossState currentState;

    void Start()
    {
        
    }

    void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateLogic();
        }
    }

    void LateUpdate()
    {
        if(currentState != null)
        {
            currentState.UpdatePhysics();
        }
    }

    void ChangeState(BossState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
