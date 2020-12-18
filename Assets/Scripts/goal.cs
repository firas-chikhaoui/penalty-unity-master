using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    private int score=0;

    bool goaled = false;


    private void OnTriggerExit(Collider other) {
         if (other.gameObject.tag=="target" && other.transform.position.z>transform.position.z && !goaled)
        {
           goaled = true;
            
            score++;
            Debug.Log(score);
            GameManager.main.addScore(other.GetComponent<TargetScript>().value);
            other.gameObject.SetActive(false);
            
        }
        

       
    }
}
