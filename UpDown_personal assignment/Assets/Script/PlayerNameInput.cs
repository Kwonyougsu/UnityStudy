using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public partial class PlayerNameInput : MonoBehaviour
{
    public InputField playerNameInputField;
    public string InputPlayerName = null;

    private void Awake()
    {
        InputPlayerName = playerNameInputField.GetComponent<InputField>().text;
    }

    private void InputName()
    {
        InputPlayerName = playerNameInputField.text;
        PlayerPrefs.SetString("Player Name", InputPlayerName);
        PlayerPrefs.Save();
    }
    

    public void ButtonOnclick()
    {
        InputName();
        if ((InputPlayerName.Length > 2 || InputPlayerName.Length < 11) && InputPlayerName.Length != 0 && InputPlayerName.Length != 1)
        {
            Debug.Log(InputPlayerName.Length);
            SceneManager.LoadScene("MainScene");
            if (PlayerPrefs.HasKey("Player Name"))
            {
                playerNameInputField.text = InputPlayerName;
            }
            else
            {
                SceneManager.LoadScene("Title");
            }
        }
        else
        {
            Debug.Log("hello");
            Debug.Log(InputPlayerName.Length);
        }
    }
}

