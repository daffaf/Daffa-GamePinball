using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider ball;
    public float multiplier;
    public Color color;
    public Renderer rendererBumper;
    private Animator anim;

    public AudioManager audioManager;
    public VFXManager VFX;

    public float score;
    public ScoreManager scoreManager;

    void Start()
    {
        rendererBumper = GetComponent<Renderer>();
        rendererBumper.material.color = color;
        anim = GetComponent<Animator>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == ball)
        {
            Rigidbody bolaRig = ball.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            anim.SetTrigger("bumperHit");
            audioManager.playSFX(collision.transform.position);
            VFX.playVFX(collision.transform.position);
            
            scoreManager.AddScore(score);

        }
    }
}
