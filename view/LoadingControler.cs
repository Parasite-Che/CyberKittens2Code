using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class LoadingControler : MonoBehaviour
{
    [SerializeField] private GameObject LoadingScreen;
    [SerializeField] private List<GameObject> Comicses;
    [SerializeField] private InputActionMap _binding;
    public static bool LoadingCompleted = false;

    private void Awake()
    {
        PlayerPrefs.SetInt("loading", 0);
        StartCoroutine(LoadingSimulator());
        
    }

    public IEnumerator LoadingSimulator()
    {
        Time.timeScale = 0;

         LoadingScreen.SetActive(true);
         if (Comicses.Count > 0)
         {
             for (int i = 0; i < Comicses.Count; i++)
             {
                 Comicses[i].SetActive(true);
             }
         }


         for (int i = 600; i > 0; i--)
         {
             yield return null;
         }
         
         yield return FadePanel(LoadingScreen, 50);
         LoadingScreen.SetActive(false);
         
         if (Comicses.Count <= 0)
         {
             yield break;
         }

         _binding.Enable();
         _binding.FindAction("skip").performed += Complete;

         for (int i = 0; i < Comicses.Count; i++)
         {
             PlayerPrefs.SetInt("loading", 0);
             for (int j = 600; j > 0; j--)
             {
                 if (PlayerPrefs.GetInt("loading") == 1) 
                 {
                     break;
                 }
                 yield return null;
             }
             yield return FadePanel(Comicses[i], 50);

             Comicses[i].SetActive(false);
         }

         LoadingCompleted = true;
         _binding.Disable();
         Time.timeScale = 1;

    }

    private void Complete(InputAction.CallbackContext obj)
    {
        PlayerPrefs.SetInt("loading", 1);
    }

    public IEnumerator FadePanel(GameObject panel, int speed)
    {
        for (int j = 0; j <= speed; j++)
        {
            panel.GetComponent<Image>().color = new Color(panel.GetComponent<Image>().color.r,
                panel.GetComponent<Image>().color.g, panel.GetComponent<Image>().color.b,
                Mathf.Lerp(1, 0, (float)j / speed));
            yield return null;
        }
    }
    
}
