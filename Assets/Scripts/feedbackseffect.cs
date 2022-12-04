using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class feedbackseffect : MonoBehaviour
{
    public AudioClip GrabbableAudio;

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "LeftHandAnchor" || col.name == "RightHandAnchor" )
        {
            GetComponent<AudioSource>().PlayOneShot(GrabbableAudio);
        }

    }
}
