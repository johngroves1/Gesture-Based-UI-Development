using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class CharacterSelectionController : MonoBehaviour
{
   public SpriteRenderer sr;
   public Animator am;
   public List<Sprite> skins = new List<Sprite>();

   public List<RuntimeAnimatorController> animation = new List<RuntimeAnimatorController>();
   private int selectedSkin = 0;
   private int selectedAnimation = 0;
   public GameObject playerskin;
   //public GameObject playerAnimation;

   public void NextOption()
   {
       selectedSkin = selectedSkin + 1;
      
       if (selectedSkin == skins.Count)
       {
           selectedSkin = 0;
           //selectedAnimation = 0;
       }
       sr.sprite = skins[selectedSkin];

        selectedAnimation = selectedAnimation + 1;

        if (selectedAnimation == animation.Count)
       {
           selectedAnimation = 0;
       }
        am.runtimeAnimatorController = animation[selectedAnimation];
   }

    public void BackOption()
   {
       selectedSkin = selectedSkin - 1;
        
       if (selectedSkin < skins.Count)
       {
           selectedSkin = skins.Count - 1;
           
       }
       sr.sprite = skins[selectedSkin];
   
        selectedAnimation = selectedAnimation - 1;
        if (selectedAnimation < animation.Count)
        {
            selectedAnimation = animation.Count - 1;
        }
        am.runtimeAnimatorController = animation[selectedAnimation];
   }

   public void PlayGame()
   {
       PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/selectedskin.prefab" );
       SceneManager.LoadScene(1);
   }
}
