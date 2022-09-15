using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonHandler : MonoBehaviour
{
    [SerializeField] GameObject inputField;
    [SerializeField] GameObject finishButton;
    [SerializeField] GameObject startButton;

    public void StartNew()
    {
        SceneManager.LoadScene(1);

        inputField.SetActive(false);
        startButton.SetActive(false);
        finishButton.SetActive(false);
    }
}
