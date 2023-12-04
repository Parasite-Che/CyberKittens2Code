using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialControler : MonoBehaviour
{
    //public ITutorialCollided TutorialCollided;
    [SerializeField] private GameObject BackGround;
    [SerializeField] private TMP_Text[] _texts;
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "tutor")
        {
            //Debug.LogError("TutorColide");
            StartCoroutine(other.GetComponent<ITutorialCollided>().TutorStart(BackGround, _texts));
        }
    }
    
    
}


public interface ITutorialCollided
{
    public IEnumerator TutorStart(GameObject Background, TMP_Text[] _texts);
}