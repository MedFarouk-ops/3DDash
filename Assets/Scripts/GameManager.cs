using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
   public GameObject LostLevel;
   public GameObject WinLevel;

   public static GameManager instance;


   void Awake(){
        instance = this;
   }

   public void WinnLevel(){
        WinLevel.SetActive(true);
   }

   public void LoseLevel(){
        LostLevel.SetActive(true);
   }

   
}
