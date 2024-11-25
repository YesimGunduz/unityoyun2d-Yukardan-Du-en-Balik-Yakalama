using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void playgame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    Time.timeScale=1;

    }
    public void mainmenu(){
    SceneManager.LoadScene("Maın Menü");
    }
    public void SettingsMenu(){
    SceneManager.LoadScene("Settıngs Menu");
    }   
    public void quitGame(){
    Application.Quit();
    }
}