using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private AudioSource deathSoundEffect;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.gameObject.CompareTag("Trap")) 
    {
        StartCoroutine(death());
    }
   }

   private IEnumerator death()
   {
    sprite.enabled = false;
    rb.bodyType = RigidbodyType2D.Static;
    deathSoundEffect.Play();

    yield return new WaitForSeconds(2);
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   private void restart()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
