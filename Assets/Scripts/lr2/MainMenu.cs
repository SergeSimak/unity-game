using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject inputFirstName; 

    public void PlayGame()
    {
        PlayerController.playerName = ScriptTestPlugin.CalculateString(inputFirstName.GetComponent<Text>().text, "Player");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    

    public void QuitGame()
    {
        Application.Quit();
    }

}
