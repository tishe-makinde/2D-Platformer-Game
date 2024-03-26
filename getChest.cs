using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getChest : MonoBehaviour
{
    [SerializeField] private AudioSource finishSoundEffect;
    private bool levelCompleted = false;
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSoundEffect.Play();
            levelCompleted = true;
            Invoke("completeLevel", 3f);
            
        }
    }

    private void completeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
