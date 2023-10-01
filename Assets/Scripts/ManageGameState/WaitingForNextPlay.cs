using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingForNextPlay : IState
{
    public WaitingForNextPlay(){
        Enter();
    }
    public void Enter(){
        GameManager.instance.CallEndOfTurn();
    }

    public void Tick(){

    }

    public void Leave(){
        
    }

}
