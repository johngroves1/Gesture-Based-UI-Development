using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selector : MonoBehaviour
{
    public GameObject Octo;
    public GameObject Astro;
    public GameObject Cosmic;
    public GameObject Slime;
    private Vector3 CharacterPosition;
    private Vector3 OffScreen;
    private int CharacterInt = 1;
    private SpriteRenderer OctoRenderer, AstroRenderer, CosmicRenderer, SlimeRenderer;
    private Animator OctoAnimator, AstroAnimator, CosmicAnimator, SlimeAnimator;
    private readonly string selectedCharacter = "SelectedCharacter";
    public SwipeDetection swipeControls;

    public GameObject canvas;

    private void Awake()
    {
        CharacterPosition = Octo.transform.position;
        OffScreen = Cosmic.transform.position;
        OctoRenderer = Octo.GetComponent<SpriteRenderer>();
        AstroRenderer = Astro.GetComponent<SpriteRenderer>();
        CosmicRenderer = Cosmic.GetComponent<SpriteRenderer>();
        SlimeRenderer = Slime.GetComponent<SpriteRenderer>();

        OctoAnimator = Octo.GetComponent<Animator>();
        AstroAnimator = Astro.GetComponent<Animator>();
        CosmicAnimator = Cosmic.GetComponent<Animator>();
        SlimeAnimator = Slime.GetComponent<Animator>();
    }

    private void Update()
    {

        if (swipeControls.SwipeRight)
        {
            NextCharacter();
        }
        // Swipe down opens pause menu
        if (swipeControls.SwipeLeft)
        {
            PreviousCharacter();
        }
        if (canvas.activeSelf && Input.touches.Length >= 2)
        {
            ChangeScene();
        }

    }

    public void NextCharacter()
    {
        switch (CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                OctoRenderer.enabled = false;
                OctoAnimator.enabled = false;
                Octo.transform.position = OffScreen;
                Astro.transform.position = CharacterPosition;
                AstroRenderer.enabled = true;
                AstroAnimator.enabled = true;
                CharacterInt++;
                break;
            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                AstroRenderer.enabled = false;
                AstroAnimator.enabled = false;
                Astro.transform.position = OffScreen;
                Cosmic.transform.position = CharacterPosition;
                CosmicRenderer.enabled = true;
                CosmicAnimator.enabled = true;
                CharacterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                CosmicRenderer.enabled = false;
                CosmicAnimator.enabled = false;
                Cosmic.transform.position = OffScreen;
                Slime.transform.position = CharacterPosition;
                SlimeRenderer.enabled = true;
                SlimeAnimator.enabled = true;
                CharacterInt++;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                SlimeRenderer.enabled = false;
                SlimeAnimator.enabled = false;
                Slime.transform.position = OffScreen;
                Octo.transform.position = CharacterPosition;
                OctoRenderer.enabled = true;
                OctoAnimator.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;
        }
    }

    public void PreviousCharacter()
    {
        switch (CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                OctoRenderer.enabled = false;
                OctoAnimator.enabled = false;
                Octo.transform.position = OffScreen;
                Slime.transform.position = CharacterPosition;
                SlimeRenderer.enabled = true;
                SlimeRenderer.enabled = true;
                CharacterInt--;
                ResetInt();
                break;
            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 4);
                AstroRenderer.enabled = false;
                AstroAnimator.enabled = false;
                Astro.transform.position = OffScreen;
                Octo.transform.position = CharacterPosition;
                OctoRenderer.enabled = true;
                OctoAnimator.enabled = true;
                CharacterInt--;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                CosmicRenderer.enabled = false;
                CosmicAnimator.enabled = false;
                Cosmic.transform.position = OffScreen;
                Astro.transform.position = CharacterPosition;
                AstroRenderer.enabled = true;
                AstroAnimator.enabled = true;
                CharacterInt--;
                break;
            case 4:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                SlimeRenderer.enabled = false;
                SlimeAnimator.enabled = false;
                Slime.transform.position = OffScreen;
                Cosmic.transform.position = CharacterPosition;
                CosmicRenderer.enabled = true;
                CosmicAnimator.enabled = true;
                CharacterInt--;
                break;
            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if (CharacterInt >= 4)
        {
            CharacterInt = 1;
        }
        else
        {
            CharacterInt = 4;
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

}

