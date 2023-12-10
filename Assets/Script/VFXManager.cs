using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bumperparticle;
    public GameObject SwitchParticle;

    void Start()
    {
        // particle = FindObjectsByType<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(Bumperparticle, spawnPosition,Quaternion.identity);
    }
    public void PlaySwitchVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(SwitchParticle, spawnPosition,Quaternion.identity);
    }
}
