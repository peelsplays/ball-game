using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other) // Fix the capitalization here
    {
        SceneManager.LoadScene(1);
    }
}