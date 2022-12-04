using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        gameObject.transform.localPosition = new Vector3(2.916f, 1.532f, -4.288f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
