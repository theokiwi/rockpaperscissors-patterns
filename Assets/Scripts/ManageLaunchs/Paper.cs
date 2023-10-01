using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : LaunchBehaviour
{
    public void DoAction(string identifier){
    if(identifier == "player"){
        GameManager.instance.playerCurrentElement = GameManager.Elements.paper;
        GameObject PaperPlayer = GameObject.Instantiate(GameObject.Find("Paper"), GameObject.Find("PlayerFightPos").transform.position, Quaternion.identity);
    }
    else if(identifier == "machine"){
        GameManager.instance.machineCurrentElement = GameManager.Elements.paper;
        GameObject.Instantiate(GameObject.Find("Paper"), GameObject.Find("MachineFightPos").transform.position, Quaternion.identity);

    }
   }

}
