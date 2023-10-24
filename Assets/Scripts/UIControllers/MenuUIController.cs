using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuUIController : MonoBehaviour
{
public void OnClickStart(){
        SceneManager.LoadScene("Game");
    }

public void OnClickMenu(){
        SceneManager.LoadScene("Menu");
    }
}
