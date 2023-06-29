using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Organizer : MonoBehaviour
{
    public void RetryLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.instance.LostLevel.SetActive(false);
        GameManager.instance.WinLevel.SetActive(false);
   }

   public void NextLevel(){
        if(SceneManager.GetActiveScene().name == "Level1"){
            SceneManager.LoadScene("Level2");
        }
   }
}
