using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInputController : MonoBehaviour
{
    public static TextInputController Instance;

    [SerializeField] string enteredName;
    [SerializeField] GameObject inputField;
    [SerializeField] GameObject displayedText;

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
