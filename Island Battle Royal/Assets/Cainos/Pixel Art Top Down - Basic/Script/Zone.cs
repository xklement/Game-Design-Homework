using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zone : MonoBehaviour
{
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        GameObject test = collision.gameObject;
        
        Destroy(collision.gameObject);
        if (test.tag == "Player")
            SceneManager.LoadScene("GameOver");
        else if (test.tag == "Enemy") {
            count++;
        }
        if (count >= 5) {
            SceneManager.LoadScene("win");
        }
    }
}
