using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonsInitialize : MonoBehaviour
{
    [SerializeField] private InputActionMap buttons;
    [SerializeField] private GameObject pausePanel;

    private void Awake()
    {
        buttons.Enable();
        buttons.FindAction("Pause").performed += PausePanelController;
    }

    private void PausePanelController(InputAction.CallbackContext obj)
    {
        if (pausePanel.activeSelf == false)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
    

}
