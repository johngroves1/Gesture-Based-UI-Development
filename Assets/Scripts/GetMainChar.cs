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
    
    // Start is called before the first frame update
    void Start()
    {
        int getCharacter;

        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch(getCharacter)
        {
            case 1:
                mySprite.sprite = astro;
                //mySpriteAnimation.runtimeAnimatorController = astroAni;
                Player.GetComponent<Animator>().runtimeAnimatorController = astroAni;
                break;
            case 2:
                mySprite.sprite = cosmic;
               // mySpriteAnimation.runtimeAnimatorController = cosmicAni;
                Player.GetComponent<Animator>().runtimeAnimatorController = cosmicAni;
                break;
            case 3:
                mySprite.sprite = slime;
                //mySpriteAnimation.runtimeAnimatorController = slimeAni;
                Player.GetComponent<Animator>().runtimeAnimatorController = slimeAni;
                break;
            case 4:
                mySprite.sprite = octo;
               // mySpriteAnimation.runtimeAnimatorController = octoAni;
                Player.GetComponent<Animator>().runtimeAnimatorController = octoAni;
                break;
            default:
                mySprite.sprite = octo;
                //mySpriteAnimation.runtimeAnimatorController = octoAni;
                Player.GetComponent<Animator>().runtimeAnimatorController = octoAni;
                break;
                
        }
    }

   
}
