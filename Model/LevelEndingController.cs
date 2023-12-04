using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelEndingController : MonoBehaviour
{
    [SerializeField] private List<GameObject> Comicses;
    [SerializeField] private InputActionMap _binding;
    public static bool LoadingCompleted = false;
    [SerializeField] private int sceneNum;
    
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent<PlayerController>(out PlayerController pc))
        {
            
            PlayerPrefs.SetInt("Ending", 0);
            StartCoroutine(LoadingSimulator());
            
        }
    }
    
    public IEnumerator LoadingSimulator()
    {
        Time.timeScale = 0;
     
        if (Comicses.Count > 0)
        {
            for (int i = 0; i < Comicses.Count; i++)
            {
                Comicses[i].SetActive(true);
            }
        }

        
        if (Comicses.Count <= 0)
        {
            yield break;
        }

        _binding.Enable();
        _binding.FindAction("skip").performed += Complete;

        for (int i = 0; i < Comicses.Count; i++)
        {
            PlayerPrefs.SetInt("Ending", 0);
            for (int j = 600; j > 0; j--)
            {
                if (PlayerPrefs.GetInt("Ending") == 1) 
                {
                    break;
                }
                yield return null;
            }
            //yield return FadePanel(Comicses[i], 50);

            //Comicses[i].SetActive(false);
        }

        LoadingCompleted = true;
        _binding.Disable();
        
        
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneNum);
    }

    private void Complete(InputAction.CallbackContext obj)
    {
        PlayerPrefs.SetInt("Ending", 1);
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
