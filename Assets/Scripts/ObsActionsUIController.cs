using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsActionsUIController : MonoBehaviour
{
    public void ClickButtonRock(){
        NotifyMachines();
        SubjectUIActions.subject.NotifyObserver(WhichEnum.Rock);
    }

    public void ClickButtonPaper(){
        NotifyMachines();
        SubjectUIActions.subject.NotifyObserver(WhichEnum.Paper);
    }

    public void ClickButtonScissors(){
        NotifyMachines();
        SubjectUIActions.subject.NotifyObserver(WhichEnum.Scissors);
    }

    public void NotifyMachines(){
        SubjectUIActions.subject.NotifyObserver(WhichEnum.MachineAction);

    }
}
