using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateElement : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Paper;
    public GameObject Scissors;

    public Transform PlayerFightPos;
    public Transform MachineFightPos;

    public static CreateElement create;

    public void Start(){
        create = this;
    }
    
    public void InstantiateRock(string identifier){
        if(identifier == "player"){
            GameManager.instance.playerCurrentElement = GameManager.Elements.rock;
            GameObject InstantiedRockPlayer = GameObject.Instantiate(Rock, PlayerFightPos.position, Quaternion.identity);
            CallForDestruction(InstantiedRockPlayer);

        }
        else if(identifier =="machine"){
            GameManager.instance.machineCurrentElement = GameManager.Elements.rock;
            GameObject InstantiatedRockMachine = GameObject.Instantiate(Rock, MachineFightPos.position, Quaternion.identity);
            CallForDestruction(InstantiatedRockMachine);

        }
    }

    public void InstantiatePaper(string identifier){
        if(identifier == "player"){
            GameManager.instance.playerCurrentElement = GameManager.Elements.paper;
            GameObject InstantiatedPaperPlayer = GameObject.Instantiate(Paper, PlayerFightPos.position, Quaternion.identity);
            CallForDestruction(InstantiatedPaperPlayer);

        }
        else if(identifier =="machine"){
            GameManager.instance.machineCurrentElement = GameManager.Elements.paper;
            GameObject InstantiedPaperMachine = GameObject.Instantiate(Paper, MachineFightPos.position, Quaternion.identity);
            CallForDestruction(InstantiedPaperMachine);

        }
    }

    public void InstantiateScissors(string identifier){
        if(identifier == "player"){
            GameManager.instance.playerCurrentElement = GameManager.Elements.scissors;
            GameObject InstantiedScissorsPlayer = GameObject.Instantiate(Scissors, PlayerFightPos.position, Quaternion.identity);
            CallForDestruction(InstantiedScissorsPlayer);

        }
        else if(identifier =="machine"){
            GameManager.instance.machineCurrentElement = GameManager.Elements.scissors;
            GameObject InstantiedScissorsMachine = GameObject.Instantiate(Scissors, MachineFightPos.position, Quaternion.identity);
            CallForDestruction(InstantiedScissorsMachine);
        }
    }

    public void CallForDestruction(GameObject objectToDestroy){
        StartCoroutine(DestroyObject(objectToDestroy));
    }

    IEnumerator DestroyObject(GameObject objectToDestroy){
        yield return new WaitForSeconds(0.8f);
        Destroy(objectToDestroy);
    }
}
