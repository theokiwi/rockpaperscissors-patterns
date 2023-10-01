using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsActionsUIController : MonoBehaviour
{
    public void ClickButtonRock(){
        NotifyMachine();
        SubjectUIActions.subject.NotifyObserver(WhichEnum.Rock);
    }

    public void ClickButtonPaper(){
        NotifyMachine();
        SubjectUIActions.subject.NotifyObserver(WhichEnum.Paper);
    }

    public void ClickButtonScissors(){
        NotifyMachine();
        SubjectUIActions.subject.NotifyObserver(WhichEnum.Scissors);
    }

    public void NotifyMachine(){
        SubjectUIActions.subject.NotifyObserver(WhichEnum.MachineAction);
    }
}
