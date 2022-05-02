using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OsuLoader;

public class ChartLoader : MonoBehaviour
{
    public int songIndex;
    public int diffIndex;
    private BeatMap beatMap;

    // Start is called before the first frame update
    void Start()
    {
        LoadFile();
    }

    public void LoadFile()
    {
        string song = "";
        switch (songIndex)
        {
            case 0:
                song = "466946 t+pazolite - Call me it (500 Tortures)";
                break;
            case 1:
                song = "476221 t+pazolite - CENSORED!!";
                break;
            case 2:
                song = "173612 xi - FREEDOM DiVE";
                break;
            case 3:
                song = "639647 Camellia - GHOST";
                break;
            case 4:
                song = "1224617 Kobaryo - Invisible Frenzy";
                break;
            case 5:
                song = "484327 t+pazolite - Pumpin' Junkies";
                break;
            default:
                Debug.Log("songIndex is higher than number of songs");
                break;
        }

        // Sets a path for all .osu files for 1 song
        string path = "/Unity Stuff/OSU MAPS/" + song;
        string[] files = System.IO.Directory.GetFiles(path, "*.osu");
        // Puts difficulty names into an array
        string[] difficulties = new string[files.Length];

        // Array of beatmaps (one for each difficulty)
        BeatMap[] bms = new BeatMap[files.Length];
        for (int i = 0; i < bms.Length; i++)
        {
            bms[i] = OsuLoader.OsuLoader.LoadDotOsu(files[i]);
            // Gets difficulty name from the file name
            int length = files[i].Substring(files[i].IndexOf('[')).Length;
            difficulties[i] = files[i].Substring(files[i].IndexOf('[') + 1, length - 6);
        }

        // DEBUG - prints difficulty names and single note count
        
        for (int i = 0; i < difficulties.Length; i++)
        {
            Debug.Log(difficulties[i]);
            Debug.Log(bms[i].SingleNotes.Count);
        }

        // Loads the beatmap of the difficulty selected
        if (diffIndex <= difficulties.Length)
        {
            beatMap = bms[diffIndex];
        }
        Debug.Log(beatMap.SingleNotes.Count);
        Debug.Log(files[diffIndex]);
    }
}
