using System.Collections;
using System.Collections.Generic;
using GameFramework.Fsm;
using UnityEngine;

public class PlayerRun : FsmState<GameController>
{
    protected internal override void OnInit(IFsm<GameController> fsm)
    {
        base.OnInit(fsm);
        
        Debug.Log("OnInit PlayerRun");
    }

    protected internal override void OnEnter(IFsm<GameController> fsm)
    {
        base.OnEnter(fsm);
        
        Debug.Log("OnEnter PlayerRun");
    }

    protected internal override void OnUpdate(IFsm<GameController> fsm, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);

        if (Input.GetKeyDown(KeyCode.S))
        {
            ChangeState<PlayerWalk>(fsm);
        }
    }

    protected internal override void OnLeave(IFsm<GameController> fsm, bool isShutdown)
    {
        base.OnLeave(fsm, isShutdown);
        
        Debug.Log("OnLeave PlayerRun");
    }

    protected internal override void OnDestroy(IFsm<GameController> fsm)
    {
        base.OnDestroy(fsm);
        
        Debug.Log("OnDestroy PlayerRun");
    }
}