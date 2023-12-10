using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    // Start is called before the first frame update

    private enum switchState
    {
        off,
        on,
        blink,
    }
    public Collider ball;

    public Material offMaterial;
    public Material onMaterial;

    private Renderer rendererSwitch;
    private switchState state;

    public VFXManager VFX;
    public AudioManager audioManager;
    
    void Start()
    {
        rendererSwitch = GetComponent<Renderer>();
        Set(false);
        StartCoroutine(blinkTimerStart(5));
    }
    
     private void OnTriggerEnter(Collider other)
    {
        if(other == ball)
        {
            Toogle();
            
        }
    }
    private void Set(bool active)
    {
        
        if(active == true)
        {
           state = switchState.on;
           rendererSwitch.material = onMaterial;
           VFX.PlaySwitchVFX(transform.position);
           StopAllCoroutines();
        }else
        {
            state = switchState.off;
            rendererSwitch.material = offMaterial;
            StartCoroutine(blinkTimerStart(5));
        }
    }
    
    private void Toogle()
    {
        audioManager.playSwitchSFX(transform.position);
        if(state == switchState.on)
        {
            Set(false);
        }else
        {
            Set(true);
        }   
    }
   
    private IEnumerator Blink(int times){

       state = switchState.blink;

        for(int i=0; i<times; i++)
        {
            rendererSwitch.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            rendererSwitch.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = switchState.off;
        StartCoroutine(blinkTimerStart(5));
        
    }

    private IEnumerator blinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
