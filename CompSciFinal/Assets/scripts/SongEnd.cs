using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongEnd : MonoBehaviour
{
    public static void SongFinished()
    {
        SceneManager.LoadScene("End Screen");
    }
}
