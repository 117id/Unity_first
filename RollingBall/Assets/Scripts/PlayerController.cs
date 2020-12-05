using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int Coins = 0;
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        SoundManager.instance.PlaySound();
        Destroy(other.gameObject);
        Coins ++;
    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal,0.0f, moveVertical);
        rb.AddForce(movement * speed);
        if(Coins == 8)
        {
            SceneManager.LoadScene("Ending Scene");
        }
    }

}
