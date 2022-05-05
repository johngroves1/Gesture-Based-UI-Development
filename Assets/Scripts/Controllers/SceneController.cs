using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{

    [SerializeField] private GameObject characterMenuUI;
    [SerializeField] private GameObject characters;



    public void Start_OnClick()
    {
        SceneManager.LoadScene(1); 
    }

    public void StartGame_OnClick()
    {
        SceneManager.LoadScene(1); 
    }

    public void Menu_OnClick()
    {
        SceneManager.LoadScene(0); 
    }

    public void Char_OnClick()
    {
        characterMenuUI.SetActive(true);
        characters.SetActive(true);
    }

    private void Update()
    {
        if (Input.touches.Length == 1)
        {
            Start_OnClick();
        }
    }


}
