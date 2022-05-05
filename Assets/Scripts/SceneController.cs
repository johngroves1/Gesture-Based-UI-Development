using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{

    [SerializeField] private GameObject characterMenuUI;
    [SerializeField] private GameObject characters;


        // Start is called before the first frame update
    // == onClick Event Handlers ==
    public void Start_OnClick()
    {
        SceneManager.LoadScene(1); // Make sure the scene is added in the Build Settings
    }

    public void StartGame_OnClick()
    {
        SceneManager.LoadScene(1); // Make sure the scene is added in the Build Settings
    }

    public void Menu_OnClick()
    {
        SceneManager.LoadScene(0); // Make sure the scene is added in the Build Settings
    }

    public void Char_OnClick()
    {
        characterMenuUI.SetActive(true);
        characters.SetActive(true);
    }

    
}
