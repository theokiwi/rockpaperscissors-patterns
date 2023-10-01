using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectUIActions : MonoBehaviour
{
    private List <IObserver> observers =  new List<IObserver>();
    public static SubjectUIActions subject;
    public void OnEnable()
    {
        subject = this;
    }

    public void AddObserver(IObserver obs){
        observers.Add(obs);
    }

    public void RemoveObserver(IObserver obs){
        observers.Remove(obs);
    }

    public void NotifyObserver(WhichEnum observerAction){
        foreach(IObserver obs in observers){
            obs.OnNotify(observerAction);
        }
    }
}
