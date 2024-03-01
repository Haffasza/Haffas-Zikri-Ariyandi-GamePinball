using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public Button playButton;
    public Button creditButton;
    public Button exitButton;

    // Start is called before the first frame update
    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        creditButton.onClick.AddListener(CreditGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("pinball");
    }

    public void CreditGame()
    {
        SceneManager.LoadScene("Credit");
    }

    // Update is called once per frame
    private void ExitGame()
    {
        Application.Quit();
    }
}
