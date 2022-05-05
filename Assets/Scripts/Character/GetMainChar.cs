using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainChar : MonoBehaviour
{
    public GameObject Player;
    public Sprite astro, octo, cosmic, slime;
    public RuntimeAnimatorController astroAni, octoAni, cosmicAni, slimeAni;
    private SpriteRenderer mySprite;
    private Animator mySpriteAnimation;
    private readonly string selectedCharacter = "SelectedCharacter";

    void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();
    }
    
    void Start()
    {
        int getCharacter;

        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        // Switch case to move between playable characters
        switch(getCharacter)
        {
            case 1:
                Player.GetComponent<SpriteRenderer>().sprite = astro;  
                Player.GetComponent<Animator>().runtimeAnimatorController = astroAni;
                break;
            case 2:
                Player.GetComponent<SpriteRenderer>().sprite = cosmic;            
                Player.GetComponent<Animator>().runtimeAnimatorController = cosmicAni;
                break;
            case 3:
                Player.GetComponent<SpriteRenderer>().sprite = slime;
                Player.GetComponent<Animator>().runtimeAnimatorController = slimeAni;
                break;
            case 4:
                Player.GetComponent<SpriteRenderer>().sprite = cosmic;
                Player.GetComponent<Animator>().runtimeAnimatorController = octoAni;
                break;
            default:
                Player.GetComponent<SpriteRenderer>().sprite = octo;
                Player.GetComponent<Animator>().runtimeAnimatorController = octoAni;
                break;
                
        }
    }

   
}
