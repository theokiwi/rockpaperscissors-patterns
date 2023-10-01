using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IObserver
{
    public string identifier = "player";
    public LaunchBehaviour launchAction;

    public void Start(){
        SubjectUIActions.subject.AddObserver(this);
    }

    public void OnNotify(WhichEnum observerAction){
        GameManager.instance.ChangeState(new WaitingForNextPlay());
        switch(observerAction){
            case WhichEnum.Rock:
                WasRock();
            break;

            case WhichEnum.Paper:
                WasPaper();
            break;

            case WhichEnum.Scissors:
                WasScissors();
            break;
        }
    }

    public void OnDisable(){
        SubjectUIActions.subject.RemoveObserver(this);
    }
    public void WasRock(){
        launchAction = new Rock();
        launchAction.DoAction(identifier);
    }

    public void WasPaper(){
        launchAction = new Paper();
        launchAction.DoAction(identifier);  
    }

    public void WasScissors(){
        launchAction = new Scissors();
        launchAction.DoAction(identifier);  
    }
}
