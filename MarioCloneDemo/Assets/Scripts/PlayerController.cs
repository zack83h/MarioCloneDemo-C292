using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;


    private Rigidbody2D rb;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 location = transform.position;
        Vector3 scale = transform.localScale;
        currentHealth = 20;
        UIManagerHealth.Instance.ChangeHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //can also get the input in jump itself then call jump every frame
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) 
        {
            Jump();
        }
        
        Move();

        if(currentHealth == 0)
        { 
            SceneManager.LoadScene(0);
        }

    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        // Vector2.right -> (1,0)
        transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);

    }

    private void Jump()
    {
        // Vector2.right -> (0,1)
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    bool IsGrounded()
    {
        return rb.velocity.y == 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            currentHealth -= 1;
            UIManagerHealth.Instance.ChangeHealth(currentHealth);
        }
    }


}
