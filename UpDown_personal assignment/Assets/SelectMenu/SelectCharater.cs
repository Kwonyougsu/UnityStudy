using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharater : MonoBehaviour
{

    public GameObject CharacterList; 
    public Image characterImage; 
    public Sprite[] characterSprites = new Sprite[2]; 

    public void CloseCharacterSelectionPopup()
    {
        CharacterList.SetActive(false);
    }

    public void SelectCharacter(int characterIndex)
    {
        characterImage.sprite = characterSprites[characterIndex];
        CloseCharacterSelectionPopup();
    }
}
