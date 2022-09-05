using System.Collections;
using System.Collections.Generic;
using GameFramework.Fsm;
using UnityEngine;

public class PlayerWalk : FsmState<GameController>
{
    protected internal override void OnInit(IFsm<GameController> fsm)
    {
        base.OnInit(fsm);

        Debug.Log("OnInit PlayerWalk");
    }

    protected internal override void OnEnter(IFsm<GameController> fsm)
    {
        base.OnEnter(fsm);

        Debug.Log("OnEnter PlayerWalk");
    }

    protected internal override void OnUpdate(IFsm<GameController> fsm, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);

        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeState<PlayerRun>(fsm);
        }
    }

    protected internal override void OnLeave(IFsm<GameController> fsm, bool isShutdown)
    {
        base.OnLeave(fsm, isShutdown);

        Debug.Log("OnLeave PlayerWalk");
    }

    protected internal override void OnDestroy(IFsm<GameController> fsm)
    {
        base.OnDestroy(fsm);

        Debug.Log("OnDestroy PlayerWalk");
    }
}