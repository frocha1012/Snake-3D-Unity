using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public AudioClip biteSound;
    private bool hasBeenConsumed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain") && !hasBeenConsumed)
        {
            hasBeenConsumed = true;

            // Play the bite sound
            if (biteSound != null)
            {
                AudioSource.PlayClipAtPoint(biteSound, transform.position);
            }

            other.GetComponent<SnakeMovment>().AddTail();
            Destroy(gameObject);
        }
    }
}
