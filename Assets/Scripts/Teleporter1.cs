using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter1 : MonoBehaviour
{
    //public Transform OVRPlayerController;
    public GameObject OVRPlayerController;
    public GameObject TeleportTo, player;

    private void OnTriggerEnter (Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            player.SetActive(false);
            OVRPlayerController.transform.position = TeleportTo.transform.position;
            player.SetActive(true);
        }
    }
}
