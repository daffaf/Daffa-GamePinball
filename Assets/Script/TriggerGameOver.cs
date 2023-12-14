using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverCanvas;
    public Collider ball;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other == ball)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}
