using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : LaunchBehaviour
{
    public string desiredTag = "Clone";
   public void DoAction(string identifier){
        CreateElement.create.InstantiateRock(identifier);
   }
}
