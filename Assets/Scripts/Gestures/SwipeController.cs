using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    public SwipeDetection swipeControls;
    public Transform player;


    private void Start()
    {

    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }


    // Update is called once per frame
    private void Update()
    {
        if (swipeControls.SwipeLeft)
        {

        }
        if (swipeControls.SwipeRight)
        {

        }
        if (swipeControls.SwipeUp)
        {
            ResumeGame();
        }

        if (swipeControls.SwipeDown)
        {
            PauseGame();
        }


    }
}
