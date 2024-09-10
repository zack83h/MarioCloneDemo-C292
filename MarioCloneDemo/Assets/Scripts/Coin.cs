using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int pointValue;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //when the player collects a coin, delete the coin and add to the score
            UIManager.Instance.IncreaseScore(pointValue);
            Destroy(gameObject);
        }
    }

}
