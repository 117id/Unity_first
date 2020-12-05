using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Sound : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
