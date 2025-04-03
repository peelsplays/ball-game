using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Coin : MonoBehaviour
{
    
    public int coinCount = 0;
    public AudioClip coinSound;  // Assign this in the Inspector

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Coin"))  
        {
            // Play sound
            AudioSource.PlayClipAtPoint(coinSound, transform.position);

            // Increase coin count
            coinCount++;
            Debug.Log("Coin collected: " + coinCount);

            // Destroy the coin
            Destroy(other.gameObject);
        }
        if (coinCount == 30)
        {
             SceneManager.LoadScene(0);
        }
    }
   
}