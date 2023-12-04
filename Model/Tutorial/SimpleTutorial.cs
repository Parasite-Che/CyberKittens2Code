using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SimpleTutorial : MonoBehaviour, ITutorialCollided
{

    [SerializeField] private string[] texts;
    [SerializeField] private string tutorName;
    [SerializeField] private string action;
    [SerializeField] private InputActionMap _binding;

    [SerializeField] private bool complete = false;
    
    private void Awake()
    {
        PlayerPrefs.SetInt(tutorName, 0);

        if (PlayerPrefs.GetInt(tutorName) == 0)
        {
            PlayerPrefs.SetInt(tutorName, 0);
        }
        else if(PlayerPrefs.GetInt(tutorName) == 1)
        {
            gameObject.SetActive(false);
        }
        
        
    }

    private void Complete(InputAction.CallbackContext obj)
    {
        PlayerPrefs.SetInt(tutorName, 1);
    }

    public IEnumerator TutorStart(GameObject Background, TMP_Text[] _texts)
    {
        while (LoadingControler.LoadingCompleted == false)
        {
            yield return null;
        }
        
        
        _binding.Enable();
        _binding.FindAction(action).performed += Complete;
        
        if(_texts.Length > 0)
            _texts[0].text = texts[0];
        Time.timeScale = 0;

        yield return FadeAll(_texts, Background, 20, 0,1);

        if (texts.Length == 1)
        {
            while (PlayerPrefs.GetInt(tutorName) == 0)
            {
                yield return null;
            }
        }
        else
        {
            for (int i = 0; i < texts.Length; i++)
            {
                PlayerPrefs.SetInt(tutorName, 0);
                _texts[0].text = texts[i];
                while (PlayerPrefs.GetInt(tutorName) == 0)
                {
                    yield return null;
                }
            }
        }

        yield return FadeAll(_texts, Background, 20, 1,0);
        
        while (complete == false)
        {
            yield return null;
        }
        Time.timeScale = 1;
        _binding.Disable();
        gameObject.SetActive(false);
    }

    private  IEnumerator FadeAll(TMP_Text[] texts, GameObject panel, int speed, float startAlpha, float endAlpha)
    {
        StartCoroutine(FadePanel(panel, speed, startAlpha, endAlpha));

        for (int i = 0; i < texts.Length; i++)
        {
            StartCoroutine(FadeText(texts[i], speed, startAlpha, endAlpha));
        }

        yield return null;
    }
    
    private  IEnumerator FadePanel(GameObject panel, int speed, float startAlpha, float endAlpha)
    {
        complete = false;
        for (int j = 0; j <= speed; j++)
        {
            panel.GetComponent<Image>().color = new Color(panel.GetComponent<Image>().color.r,
                panel.GetComponent<Image>().color.g, panel.GetComponent<Image>().color.b,
                Mathf.Lerp(startAlpha, endAlpha, (float)j / speed));
            yield return null;
        }

        complete = true;
    }
    
    private IEnumerator FadeText(TMP_Text text, int speed, float startAlpha, float endAlpha)
    {
        for (int j = 0; j <= speed; j++)
        {
            text.GetComponent<TMP_Text>().color = new Color(text.GetComponent<TMP_Text>().color.r,
                text.GetComponent<TMP_Text>().color.g, text.GetComponent<TMP_Text>().color.b,
                Mathf.Lerp(startAlpha, endAlpha, (float)j / speed));
            yield return null;
        }
    }
    
}
