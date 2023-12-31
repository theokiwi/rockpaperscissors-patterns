using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int playerLifes;
    public int machineLifes;

    public enum Elements {none, rock, paper, scissors};
    public enum Players {player, machine, none};
    public Players loser;
    public Elements playerCurrentElement;
    public Elements machineCurrentElement;

    public static GameManager instance;
    public IState currentState;

    void OnEnable(){
        if (instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }
        //DontDestroyOnLoad(gameObject);
        
        loser = Players.none;
        playerCurrentElement = Elements.none;
        machineCurrentElement = Elements.none;

        currentState = new InGame();

        playerLifes = 6;
        machineLifes = 6;
        
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        currentState = new Paused();
        }
    }

    public void whoLost(Elements playerCurrentElement, Elements machineCurrentElement){
        loser = Players.none;
        if(playerCurrentElement == Elements.rock && machineCurrentElement == Elements.paper){
            loser = Players.player;
        }
        else if(playerCurrentElement == Elements.paper && machineCurrentElement == Elements.scissors){
            loser = Players.player;
        }
        else if(playerCurrentElement == Elements.scissors && machineCurrentElement == Elements.rock){
            loser = Players.player;
        }
        else if(machineCurrentElement == Elements.rock && playerCurrentElement == Elements.paper){
            loser = Players.machine;
        }
        else if(machineCurrentElement == Elements.paper && playerCurrentElement == Elements.scissors){
            loser = Players.machine;
        }
        else if(machineCurrentElement == Elements.scissors && playerCurrentElement == Elements.rock){
            loser = Players.machine;
        }
        machineCurrentElement = Elements.none;
        playerCurrentElement = Elements.none;

    }

    public void DecreaseLife(Players loser){
        Debug.Log(loser);
        if(loser == Players.player){
            playerLifes--;
            RegularUIController.rController.DecreaseLifeUI(loser);
            if(playerLifes <= 0){
                SceneManager.LoadScene("MachineWon");
            }
        }
        else if(loser == Players.machine){
            machineLifes--;
            RegularUIController.rController.DecreaseLifeUI(loser);
            if(machineLifes <= 0){
                SceneManager.LoadScene("PlayerWon");
            }
        }
    }
    
   

    public void CallEndOfTurn(){
        Invoke("Turn", 0.8f);
    }

    public void Turn(){
        whoLost (playerCurrentElement, machineCurrentElement);
        DecreaseLife(loser);
        
        Debug.Log("machineLifes " + machineLifes);
        Debug.Log("playerLifes" + playerLifes);
    }
    public void ChangeState(IState state){
        currentState = state;
    }

}