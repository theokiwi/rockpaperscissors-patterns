using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegularUIController : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject chooseMenuUI;
    public static RegularUIController rController;

    public void Start(){
        rController = this;
        
    }
    public void OnClickStart(){
        SceneManager.LoadScene("Game");
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
        chooseMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Paused.isPaused = false;
        GameManager.instance.currentState = new InGame();
    }

    public void OnButtonQuit(){
        Application.Quit();
    }
    public void OnClickMenu(){
        SceneManager.LoadScene("Menu");
    }
}
