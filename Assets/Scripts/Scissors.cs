using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : LaunchBehaviour
{
 public void DoAction(string identifier){
    if(identifier == "player"){
        GameObject.Instantiate(GameObject.Find("Scissors"), GameObject.Find("PlayerFightPos").transform.position, Quaternion.identity);
    }
    else if(identifier == "machine"){
        GameObject.Instantiate(GameObject.Find("Scissors"), GameObject.Find("MachineFightPos").transform.position, Quaternion.identity);
    }
   }
}
