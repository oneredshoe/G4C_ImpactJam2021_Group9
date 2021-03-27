using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Button PlayButton;
    public Button OptionsButton;
    public Button QuitButton;
    public float Temps = 9f;

    void Start ()
    {
        PlayButton.interactable = false;
        OptionsButton.interactable = false;
        QuitButton.interactable = false;
    }

    private void Update()
    {
        if (Temps >= 0)
        {
            Temps -= Time.deltaTime;
        }
        
        else
        {
            PlayButton.interactable = true;
            OptionsButton.interactable = true;
            QuitButton.interactable = true;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
