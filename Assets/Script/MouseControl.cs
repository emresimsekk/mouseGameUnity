using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MouseControl : MonoBehaviour
{
    
    public Sprite[] right;
    public Sprite[] left;
    public Sprite[] bottom;
    public Sprite[] top;
    public Sprite[] front;
    public Sprite[] back;
    SpriteRenderer spriteRenderer;
    private Vector2 moveVelocity;
    Rigidbody2D physics;
    int count = 0;
    public float speed = 1;
    float horizontal = 0;
    float vertical = 0;
    public Text timer;
    public float zaman;
    bool isCount = true;
    



    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        physics = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        physics.MovePosition(physics.position + moveVelocity * Time.fixedDeltaTime);
        characterMove();
        characterAnimation();

        if(isCount)
        {
            zaman += Time.deltaTime;
            timer.text = zaman.ToString("f0");
            

        }

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "cheese")
        {
            PlayerPrefs.SetString("point", timer.text);
            SceneManager.LoadScene("PlayAgain");
        }
    }
    void characterMove()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Vector2 moveInput = new Vector2(horizontal, vertical);
        moveVelocity = moveInput * speed;

    }
    void characterAnimation()
    {
        if (horizontal == 0)
        {
            spriteRenderer.sprite = front[count++];
            if (count == front.Length)
            {
                count = 0;
            }

        }

        else if (horizontal > 0)
        {
            spriteRenderer.sprite = right[count++];
            if (count == right.Length)
            {
                count = 0;
            }
        }
        else if (horizontal < 0)
        {
            spriteRenderer.sprite = left[count++];
            if (count == left.Length)
            {
                count = 0;
            }
        }

       
         if (vertical > 0)
        {
            spriteRenderer.sprite = top[count++];
            if (count == top.Length)
            {
                count = 0;
            }
        }
        else if (vertical < 0)
        {
            spriteRenderer.sprite = bottom[count++];
            if (count == bottom.Length)
            {
                count = 0;
            }
        }
    }
}
