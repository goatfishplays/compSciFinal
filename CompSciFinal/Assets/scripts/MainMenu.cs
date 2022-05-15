using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ToSongSelect()
    {
        SceneManager.LoadScene("Song Select");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
