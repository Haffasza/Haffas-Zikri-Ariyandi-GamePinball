using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{

    public Button mainMenuButton;

    // Start is called before the first frame update
    private void Start()
    {
        mainMenuButton.onClick.AddListener(mainMenu);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
