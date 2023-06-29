using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.LoseLevel();
    }
}
