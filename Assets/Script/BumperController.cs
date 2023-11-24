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

    void Start()
    {
        rendererBumper = GetComponent<Renderer>();
        rendererBumper.material.color = color;
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == ball)
        {
            Rigidbody bolaRig = ball.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            anim.SetTrigger("bumperHit");
            
        }
    }
}
