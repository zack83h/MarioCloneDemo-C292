using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerHealth : MonoBehaviour
{
    public static UIManagerHealth Instance;
    [SerializeField] TextMeshProUGUI healthText;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeHealth(int health)
    {
        healthText.text = "Health: " + health;
    }


}
