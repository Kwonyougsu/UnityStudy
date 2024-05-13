using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ApplyName :MonoBehaviour
{
    public Text playerName;
    private void Awake()
    {
        playerName = GetComponent<Text>();
    }
    private void Start()
    {
        Load();
    }

    private void Load()
    {
        if (PlayerPrefs.HasKey("Player Name"))
        {
            playerName.text = string.Format(PlayerPrefs.GetString("Player Name"));
        }
    }
}

