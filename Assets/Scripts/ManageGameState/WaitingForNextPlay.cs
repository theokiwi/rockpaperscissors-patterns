using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingForNextPlay : IState
{
    public WaitingForNextPlay(){
        Enter();
    }
    public void Enter(){
        Debug.Log("called end of turn");
        GameManager.instance.CallEndOfTurn();
    }

    public void Tick(){

    }

    public void Leave(){
        
    }

}
