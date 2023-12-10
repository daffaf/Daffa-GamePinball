using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;
    public AudioSource sfxSwitchSource;
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }
    public void playSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource,spawnPosition, Quaternion.identity);
    }
    public void playSwitchSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchSource,spawnPosition, Quaternion.identity);
    }
}
