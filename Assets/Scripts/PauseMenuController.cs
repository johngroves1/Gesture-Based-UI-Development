using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;


    public SwipeDetection swipeControls;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        //



        if (swipeControls.SwipeUp)
        {
            DeactivateMenu();
        }
        // Swipe down opens pause menu
        if (swipeControls.SwipeDown)
        {
            ActivateMenu();
        }

        // #region "For development, comment out when building apk"
        // if (isPaused)
        // {
        //     ActivateMenu();
        // }
        // else
        // {
        //     DeactivateMenu();
        // }
        // #endregion


    }

    //

    // Shows the pause menu and set time scale to 0
    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {

        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
}
