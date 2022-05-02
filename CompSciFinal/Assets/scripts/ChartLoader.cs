using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OsuLoader;

public class ChartLoader : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip freedomDive;

    // Start is called before the first frame update
    void Start()
    {
        LoadFile();
        audio = gameObject.GetComponent<AudioSource>();
        audio.clip = freedomDive;
        audio.Play();

        
    }

    public static void LoadFile()
    {
        string path = "y:/Unity Stuff/OSU MAPS/173612 xi - FREEDOM DiVE/xi - FREEDOM DiVE (razlteh) [4K Another].osu";
        BeatMap bm = OsuLoader.OsuLoader.LoadDotOsu(path);
        
        Debug.Log(bm.FileName);
    }
}
