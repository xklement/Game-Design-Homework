using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cainos.PixelArtTopDown_Basic;

public class PushPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            StartCoroutine(pushP(collision));
    }

    public IEnumerator pushP(Collision2D collision)
    {
        Rigidbody2D obj = collision.gameObject.GetComponent<Rigidbody2D>();

        obj.drag = 1;
        //print(obj.velocity);
        // collision.gameObject.GetComponent<TopDownCharacterController>().enabled = false;
        yield return new WaitForSeconds(1f);
        obj.drag = 10;
        // collision.gameObject.GetComponent<TopDownCharacterController>().enabled = true;
        
    }
}
