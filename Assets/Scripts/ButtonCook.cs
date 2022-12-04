using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonCook : MonoBehaviour
{
    public UnityEvent onPress;
    public AudioClip ButtonAudio;

    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "RightHandAnchor" || col.name == "LeftHandAnchor")
        {
            gameObject.transform.localPosition = new Vector3(-6.49890852f, 9.26000023f, -19.2572403f);
            GetComponent<AudioSource>().PlayOneShot(ButtonAudio);
            onPress.Invoke();
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "RightHandAnchor" || col.name == "LeftHandAnchor")
        {
            gameObject.transform.localPosition = new Vector3(-6.49890852f, 9.55698299f, -19.2572403f);
        }
    }
}
