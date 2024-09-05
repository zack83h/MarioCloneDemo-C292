using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 location = transform.position;
        Vector3 scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //can also get the input in jump itself then call jump every frame
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Jump();
        }
        
        Move();

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
}
