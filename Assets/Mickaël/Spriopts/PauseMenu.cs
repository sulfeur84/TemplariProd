using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;

    public bool IsPaused;
    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!IsPaused)
            {
                GetPaused();
            }
            else
            {
                PausePanel.SetActive(false);
                Time.timeScale = 1f;
                IsPaused = false;
            }
        }
    }

    void GetPaused()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
}
