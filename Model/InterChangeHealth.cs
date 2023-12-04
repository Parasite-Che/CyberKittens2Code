using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterChangeHealth : MonoBehaviour
{
    [SerializeField] private GameObject health1;
    [SerializeField] private GameObject health2;
    [SerializeField] private GameObject health3;
    
    private void Start()
    {
        Events.onChangeInterHealth += ChangeHealth;
    }

    void ChangeHealth(int health)
    {
        switch (health)
        {
            case 0:
                health1.SetActive(false);
                health2.SetActive(false);
                health3.SetActive(false);
                break;
            case 1:
                health1.SetActive(false);
                health2.SetActive(false);
                health3.SetActive(true);
                break;
            case 2:
                health1.SetActive(false);
                health2.SetActive(true);
                health3.SetActive(true);
                break;
            case 3:
                health1.SetActive(true);
                health2.SetActive(true);
                health3.SetActive(true);
                break;
        }
    }
}
