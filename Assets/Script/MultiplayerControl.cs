using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class MultiplayerControl : NetworkBehaviour
{
    public Sprite[] right;
    public Sprite[] left;
    public Sprite[] bottom;
    public Sprite[] top;
    
   
    SpriteRenderer spriteRenderer;
    Rigidbody2D physics;
     Text timer;
    public float zaman;
    bool isCount = true;



    public float speed =0.05f;
    int count = 0;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        physics = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {

        if (!isLocalPlayer)
        {
            return;
        }
        chracterMove();





    }
        
   

    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "cheese")
        {
            
            SceneManager.LoadScene("PlayAgain");

        }
    }
   
    void chracterMove()
    {
        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.sprite = left[count++];
            if (count == left.Length)
            {
                count = 0;
            }
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        

        }
        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.sprite = right[count++];
            if (count == right.Length)
            {
                count = 0;
            }
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = top[count++];
            if (count == top.Length)
            {
                count = 0;
            }
            transform.Translate(Vector2.up * speed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            spriteRenderer.sprite = bottom[count++];
            if (count == bottom.Length)
            {
                count = 0;
            }
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }


}

        


 }
    
   

