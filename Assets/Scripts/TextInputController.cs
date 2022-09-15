using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInputController : MonoBehaviour
{
    public static TextInputController Instance;

    [SerializeField] private string enteredName;
    [SerializeField] private GameObject inputField;
    [SerializeField] private GameObject displayedText;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ReadStringInput()
    {
        enteredName = inputField.GetComponent<Text>().text;
        displayedText.GetComponent<Text>().text = "PLAYER: " + enteredName;
    }
}
