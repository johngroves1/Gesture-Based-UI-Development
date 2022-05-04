using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject selectedskin;
    public GameObject Player;

    private Sprite playersprite;
    private RuntimeAnimatorController playerAnimation;
    // Start is called before the first frame update
    void Start()
    {
        playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;
        playerAnimation = selectedskin.GetComponent<Animator>().runtimeAnimatorController;

        Player.GetComponent<SpriteRenderer>().sprite = playersprite;
        Player.GetComponent<Animator>().runtimeAnimatorController = playerAnimation;
    }

   
}
