using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float score;
    public void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    public void AddScore(float addition)
    {
        score += addition;
    }
    public void ResetScore()
    {
        score = 0;
    }
}
