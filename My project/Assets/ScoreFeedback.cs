using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreFeedback : MonoBehaviour
{
    int hits = 0;

 void OnCollisionEnter(Collision other) {
    hits = hits + 1; 
  Debug.Log("You've bumped into a thing this many times: " + hits);  
}

    
}
