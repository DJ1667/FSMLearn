using System;
using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Fsm;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private IFsmManager _fsmManager;

    private IFsm<GameController> _fsm;

    public string title = "Hello World!";

    private void Start()
    {
        _fsmManager = GameFrameworkEntry.GetModule<IFsmManager>();

        _fsm = _fsmManager.CreateFsm("Player", this, new PlayerWalk(), new PlayerRun());
        _fsm.Start<PlayerWalk>();
    }

    private void Update()
    {
        GameFrameworkEntry.Update(Time.deltaTime, Time.unscaledDeltaTime);
    }
}