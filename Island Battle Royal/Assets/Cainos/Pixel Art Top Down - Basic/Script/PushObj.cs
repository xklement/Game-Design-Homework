using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using Cainos.PixelArtTopDown_Basic;

public class PushObj : MonoBehaviour
{
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy") {
            source.Play();
            StartCoroutine(push(collision));
        }

        if (collision.gameObject.tag == "Player") {
            source.Play();
            StartCoroutine(pushPlayer(collision));
        }
    }



    public IEnumerator push(Collision2D collision)
    {
        Rigidbody2D obj = collision.gameObject.GetComponent<Rigidbody2D>();
        AIPath test = collision.gameObject.GetComponent<AIPath>();

        obj.drag = 1;
        //print(obj.velocity);
        test.canMove = false;
        yield return new WaitForSeconds(2f);
        obj.drag = 10;
        test.canMove = true;
        // collision.gameObject.GetComponent<AIPath>().enabled = true;
        
    }

    public IEnumerator pushPlayer(Collision2D collision)
    {
        Rigidbody2D obj = collision.gameObject.GetComponent<Rigidbody2D>();
        TopDownCharacterController test = collision.gameObject.GetComponent<TopDownCharacterController>();

        obj.drag = 1;
        test.canMove = false;
        //print(obj.velocity);
        // collision.gameObject.GetComponent<TopDownCharacterController>().enabled = false;
        yield return new WaitForSeconds(1f);
        obj.drag = 10;
        test.canMove = true;
        
        
    }
}
