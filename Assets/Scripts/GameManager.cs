using UnityEngine;
using UnityEngine.SceneManagement;

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


    void Awake(){
        if (instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        
        loser = Players.none;
        playerCurrentElement = Elements.none;
        machineCurrentElement = Elements.none;
    }

    public void RoundStart(){
        whoLost (playerCurrentElement, machineCurrentElement);
        DecreaseLife(loser);
        Debug.Log("machineLifes " + machineLifes);
        Debug.Log("playerLifes" + playerLifes);
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
        if(loser == Players.player){
            playerLifes--;
            if(playerLifes <= 0){
                SceneManager.LoadScene("machineWon");
            }
        }
        else if(loser == Players.machine){
            machineLifes--;
            if(machineLifes <= 0){
                SceneManager.LoadScene("playerWon");
            }
        }
        if(loser == Players.none){
            SceneManager.LoadScene("draw");
        }
    }
    
    public void NextPlay(){
        SceneManager.LoadScene(0);
    }

    public void PlayAgain(){
        playerLifes = 1;
        machineLifes = 1;
        SceneManager.LoadScene("game");
        loser = Players.none;
        playerCurrentElement = Elements.none;
        machineCurrentElement = Elements.none;

    }

    public void StartGame(){
        SceneManager.LoadScene("game");
    }

}