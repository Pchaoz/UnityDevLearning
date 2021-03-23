using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour{
int score = -1;
   private void OnCollisionEnter(Collision other) {
        
        score++;
        Debug.Log("You've bumped into a thing this many times: " + score);
        
       

    }
}
