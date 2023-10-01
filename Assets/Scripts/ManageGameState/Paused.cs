using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : IState
{
        public static bool isPaused = false;

    public Paused(){
        Enter();
    }

    public void Enter(){
        Time.timeScale = 0;
        RegularUIController.rController.ManagePauseMenu();
    }

    public void Tick(){

    }

    public void Leave(){
        
    }

    public void Pause(){

    }

    public void Resume(){
        
    }
}
