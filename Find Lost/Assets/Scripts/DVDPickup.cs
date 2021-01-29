using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DVDPickup : MonoBehaviour
{
    [SerializeField] AudioClip DVDPickupSFX;
    [SerializeField] int pointsForDVD = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsForDVD);

        //get the audio clip, then say where you want it to play which is the main camera
        AudioSource.PlayClipAtPoint(DVDPickupSFX, Camera.main.transform.position);

        Destroy(gameObject);
    }

}
