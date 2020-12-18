using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
  
    
    private int score;


    private void OnTriggerEnter(Collider other) {
         if (other.gameObject.tag=="1" )
        {
           
                 Destroy(other.gameObject);
            score++;
            Debug.Log(score);
            
           
            
        }

       
    }
}
