using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegularUIController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject chooseMenuUI;

    public Slider playerSlider;

    public Slider machineSlider;
    public static RegularUIController rController;

    public void Awake(){
       
    }
    public void Start(){
        rController = this;
        playerSlider.value = GameManager.instance.playerLifes;
        machineSlider.value = GameManager.instance.machineLifes;
        
    }

    public void ManagePauseMenu(){
        if(Paused.isPaused == false){
            pauseMenuUI.SetActive(true);
            chooseMenuUI.SetActive(false);
            Paused.isPaused = true;
        }
        else if (Paused.isPaused == true){
            Resume();
        }
    }
    
    public void Resume(){
        Time.timeScale = 1;
        chooseMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Paused.isPaused = false;
        GameManager.instance.currentState = new InGame();
    }
    public void DecreaseLifeUI(GameManager.Players loser){
        if(loser == GameManager.Players.player){
            playerSlider.value = GameManager.instance.playerLifes;
        }
        else if(loser == GameManager.Players.machine){
            machineSlider.value = GameManager.instance.machineLifes;
        }
    }
    public void OnButtonQuit(){
        Application.Quit();
    }
    public void OnClickMenu(){
        SceneManager.LoadScene("Menu");
    }
}
