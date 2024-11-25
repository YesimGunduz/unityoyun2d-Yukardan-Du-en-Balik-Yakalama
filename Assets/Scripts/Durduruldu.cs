using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;


public class Durduruldu : MonoBehaviour
{
    public void Durdur(){
    Time.timeScale=0;
    SceneManager.LoadScene("DURDURULDU");
    }
    
}
