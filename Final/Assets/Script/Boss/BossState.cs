using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossState : MonoBehaviour
{
    public string name;
    protected StateMechine stateMechine;
    public BossState(string name, StateMechine stateMechine)
    {
        this.name = name;
        this.stateMechine = stateMechine;
    }

    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void UpdateLogic() { }
    public virtual void UpdatePhysics() { }
}
