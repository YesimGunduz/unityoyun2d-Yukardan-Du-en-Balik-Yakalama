using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class oyunbitis : MonoBehaviour
{
    public void Restart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    Time.timeScale=1;

    }   
    public void exıtGame(){
    Application.Quit();
    }
    public void MenuRestart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void menuyeAT(){
    SceneManager.LoadScene("Menü");
    Time.timeScale=1;

    } 
}