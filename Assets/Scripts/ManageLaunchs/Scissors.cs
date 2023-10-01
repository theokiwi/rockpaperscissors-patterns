using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : LaunchBehaviour
{
 public void DoAction(string identifier){
    CreateElement.create.InstantiateScissors(identifier);

}
}