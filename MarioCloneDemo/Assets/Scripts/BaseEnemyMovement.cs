using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }

    private void MoveLeft()
    {
        transform.Translate(-1 * Vector2.right * moveSpeed * Time.deltaTime);
    }


}
