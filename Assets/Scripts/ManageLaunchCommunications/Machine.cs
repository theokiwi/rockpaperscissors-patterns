using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour, IObserver
{
    public string identifier = "machine";
    public LaunchBehaviour launchAction;
    

    private void Start() {
        SubjectUIActions.subject.AddObserver(this);
    }

    public void OnNotify(WhichEnum observerAction){
        if(observerAction == WhichEnum.MachineAction){
            ChooseAction();
        }
    }
    public void OnDisable(){
        SubjectUIActions.subject.RemoveObserver(this);
    }

    public void ChooseAction(){
        int actionNumber = Random.Range(1,3);
        if (actionNumber == 1){
            GameManager.instance.machineCurrentElement = GameManager.Elements.rock;
            launchAction = new Rock();
            launchAction.DoAction(identifier);
        }
        else if(actionNumber == 2){
            GameManager.instance.machineCurrentElement = GameManager.Elements.paper;
            launchAction = new Paper();
            launchAction.DoAction(identifier);
        }
        else if(actionNumber == 3){
            GameManager.instance.machineCurrentElement = GameManager.Elements.scissors;
            launchAction = new Paper();
            launchAction.DoAction(identifier);
        }
    }

}
