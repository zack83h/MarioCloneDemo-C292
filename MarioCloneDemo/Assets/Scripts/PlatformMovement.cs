using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private float startLocation;
    private float endLocation;
    [SerializeField] float distance;

    //can do Vector3.left/right for where you want it to start movement
    private Vector3 direction = Vector3.up;


    //for doing it time based
    //private float moveTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position.y;
        endLocation = startLocation + distance;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        //time
        //float currentTime += Time.deltaTime;

        //x for left and right
        if(transform.position.y >= endLocation)
        {
            direction = Vector3.down;
        }
        else if(transform.position.y <= startLocation)
        {
            direction = Vector3.up;
        }
    }



}
