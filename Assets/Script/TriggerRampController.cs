using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider ball;
    public ScoreManager scoreManager;
    public float score;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other == ball)
        {
            scoreManager.AddScore(score);
        }
    }
}
