using System;
using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public float returnTime;
    public float followSpeed;

    public float length;

    public Transform target;
    private Vector3 defaultPosition;

    public bool hasTarget {get{return target != null;}}
    void Start()
    {
        defaultPosition = transform.position;
        target = null;
    }

    // Update is called once per frame
    private void Update()
    {
        // if(Input.GetKey(KeyCode.Space))
        // {
        //     FocusAtTarget(target,5);
        // }

        // if(Input.GetKey(KeyCode.R))
        // {
        //     GoBackToDefault();
        // }

        if(hasTarget)
        {
            Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
            Vector3 targetPosition = target.position + (targetToCameraDirection * length);
            

            transform.position = Vector3.Lerp(transform.position,targetPosition, followSpeed * Time.deltaTime);

        }
    }
    public void FollowTarget(Transform targetTransform, float targetLength)
    {
        StopAllCoroutines();

        target = targetTransform;
        length = targetLength;
    }

     public void GoBackToDefault()
    {
        StopAllCoroutines();
        target = null;

        // tambahkan fungsi untuk menggerakkan posisi kamera dari target kembali ke posisi awal
        StartCoroutine(MovePosition(defaultPosition,returnTime));

    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while(timer < time)
        {
            // pindah posisi kamera secara bertahap menggunakan lerp
            transform.position = Vector3.Lerp(start ,target ,Mathf.SmoothStep(0.0f ,1.0f ,timer/time));
                                            // dilakukan berulang tiap frame selama parameter time 
            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        // mengembalikan posisi trget
        transform.position = target;
    }
    // public void FocusAtTarget(Transform targetTransform,float length)
    // {
    //     //ubah target
    //     target = targetTransform;

    //     // kalkulasi posisi kamera dari target
    //     Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
    //     Vector3 targetPosition = target.position + (targetToCameraDirection * length);

    //     // kalkulasi posisi kamera dari target dan fungsi untuk menggerakkan kamera 
    //     StartCoroutine(MovePosition(target.position,5));
    // }

   
    
}
