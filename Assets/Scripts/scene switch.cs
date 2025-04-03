using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch : MonoBehaviour
{
    void OnTriggerEnter(Collider other) // Fix the capitalization here
    {
        SceneManager.LoadScene(0);
    }
}