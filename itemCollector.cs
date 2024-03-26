using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    private int cherries = 0;
    [SerializeField] private AudioSource collectSoundEffect;

    [SerializeField] private Text cherriesText;
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.gameObject.CompareTag("Coin")) 
    {
        collectSoundEffect.Play();
        Destroy(collision.gameObject);
        cherries++;
        cherriesText.text = "Cherries: " + cherries;
    }
   }
}
