using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : LaunchBehaviour
{
   public void DoAction(string identifier){
    if(identifier == "player"){
        GameManager.instance.playerCurrentElement = GameManager.Elements.rock;
        GameObject.Instantiate(GameObject.Find("Rock"), GameObject.Find("PlayerFightPos").transform.position, Quaternion.identity);
    }
    else if(identifier == "machine"){
        GameManager.instance.machineCurrentElement = GameManager.Elements.rock;
        GameObject.Instantiate(GameObject.Find("Rock"), GameObject.Find("MachineFightPos").transform.position, Quaternion.identity);
    }
   }
}
