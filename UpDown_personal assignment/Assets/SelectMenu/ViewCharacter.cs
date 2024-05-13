using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewCharacter : MonoBehaviour
{
    public GameObject CharacterList;
    public Button select;

    private void Start()
    {
        CharacterList.SetActive(false);
        select.onClick.AddListener(CharacterView);
    }

    private void CharacterView()
    {
        CharacterList.SetActive(true);
    }
}
