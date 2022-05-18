using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public Canvas SelectedCanvas;
    public GameObject badAppleCover;
    public GameObject callMeItCover;
    public GameObject censoredCover;
    public GameObject freedomDiveCover;
    public GameObject ghostCover;
    public GameObject invisFrenzyCover;
    public GameObject pumpinJunkiesCover;
    public GameObject scatteredFaithCover;
    public GameObject villainVirusCover;

    public static int songIndex;

    public void GetSongIndex()
    {
        GameObject selectedSong = SelectedCanvas.transform.GetChild(0).gameObject;

        if(selectedSong == badAppleCover)
        {
            songIndex = 0;
        }
        else if(selectedSong == callMeItCover)
        {
            songIndex = 1;
        }
        else if(selectedSong == censoredCover)
        {
            songIndex = 2;
        }
        else if (selectedSong == freedomDiveCover)
        {
            songIndex = 3;
        }
        else if (selectedSong == ghostCover)
        {
            songIndex = 4;
        }
        else if (selectedSong == invisFrenzyCover)
        {
            songIndex = 5;
        }
        else if (selectedSong == pumpinJunkiesCover)
        {
            songIndex = 6;
        }
        else if (selectedSong == scatteredFaithCover)
        {
            songIndex = 7;
        }
        else if (selectedSong == villainVirusCover)
        {
            songIndex = 8;
        }
        else
        {
            Debug.Log("bruh");
        }

        Debug.Log(songIndex.ToString());
    }
}
