using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
     public bool isPaused = false;
    public SwipeDetection swipeControls;


    // Update is called once per frame
    private void Update()
    {

        if (swipeControls.SwipeUp)
        {
            DeactivateMenu();
        }
        // Swipe down opens pause menu
        if (swipeControls.SwipeDown)
        {
            ActivateMenu();
        }

    }

    // Shows the pause menu and set time scale to 0
    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
        isPaused = true;
    }

    public void DeactivateMenu()
    {

        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
}
