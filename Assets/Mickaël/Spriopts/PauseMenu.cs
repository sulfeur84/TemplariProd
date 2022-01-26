using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem; 

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    private InputTest PAUSE;
    public bool IsPaused;

    private InputAction Escape;
    void Start()
    {
        PausePanel.SetActive(false);
    }
    
    private void Awake()
    {
        PAUSE = new InputTest();
    }

    private void OnEnable()
    {
        Escape = PAUSE.UI.Cancel;
        Escape.Enable();
    }

    private void OnDisable()
    {
        Escape.Disable();
    }

    void Update()
    {
        if (Escape.IsPressed() && !IsPaused)
        {
            GetPaused();
        }

        else if (!Escape.IsPressed() && IsPaused)
        {
            Resume();
        }
        
    }

    public void GetPaused()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("OLALAleFAUXmenu");
    }
}
