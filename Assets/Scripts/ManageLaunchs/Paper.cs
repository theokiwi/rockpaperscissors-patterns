using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : LaunchBehaviour
{
    public void DoAction(string identifier){
        CreateElement.create.InstantiatePaper(identifier);
   }

}
