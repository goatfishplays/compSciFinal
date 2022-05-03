using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OsuLoader;

public class ChartLoader : MonoBehaviour
{
    public int songIndex;
    public int diffIndex;
    Triggering triggering;
    public GameObject clickManager;
    public GameObject note0Prefab;
    public GameObject note0Parent;
    public GameObject note1Prefab;
    public GameObject note1Parent;
    public GameObject note2Prefab;
    public GameObject note2Parent;
    public GameObject note3Prefab;
    public GameObject note3Parent;
    private BeatMap beatMap;
    private int tick = 0;

    private void Awake()
    {
        triggering = clickManager.GetComponent<Triggering>();
        LoadFile();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        /*Note testNote = new Note();
        testNote.Column = 0;
        testNote.Time = 1000;
        SpawnNote(testNote);*/

        foreach (Note note in beatMap.SingleNotes)
        {
            SpawnNote(note);
        }
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
            case 6:
                song = "523735 Kurokotei - Scattered Faith";
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
        Debug.Log(beatMap.SingleNotes[1].Column);
    }

    private void SpawnNote(Note note)
    {
        int column = note.Column;
        float time = note.Time;
        float fallSpeed = triggering.fallSpeed;

        float y = fallSpeed * time / 1000;

        switch (column)
        {
            case 0:
                Transform transformParent0 = note0Parent.GetComponent<Transform>();

                // GameObject n = Instantiate(note0Prefab, pos, Quaternion.Euler(0,0,0), transformParent) as GameObject;
                GameObject n0 = Instantiate(note0Prefab) as GameObject;
                n0.transform.parent = transformParent0;
                Rigidbody2D rigidbody0 = n0.GetComponent<Rigidbody2D>();

                n0.transform.localScale = new Vector3(1,1,1);
                n0.transform.localPosition = new Vector2(0, y);
                rigidbody0.velocity = new Vector2(0, -fallSpeed);
                break;
            case 1:
                Transform transformParent1 = note1Parent.GetComponent<Transform>();

                // GameObject n = Instantiate(note0Prefab, pos, Quaternion.Euler(0,0,0), transformParent) as GameObject;
                GameObject n1 = Instantiate(note1Prefab) as GameObject;
                n1.transform.parent = transformParent1;
                Rigidbody2D rigidbody1 = n1.GetComponent<Rigidbody2D>();

                n1.transform.localScale = new Vector3(1, 1, 1);
                n1.transform.localPosition = new Vector2(0, y);
                rigidbody1.velocity = new Vector2(0, -fallSpeed);
                break;
            case 2:
                Transform transformParent2 = note2Parent.GetComponent<Transform>();

                // GameObject n = Instantiate(note0Prefab, pos, Quaternion.Euler(0,0,0), transformParent) as GameObject;
                GameObject n2 = Instantiate(note2Prefab) as GameObject;
                n2.transform.parent = transformParent2;
                Rigidbody2D rigidbody2 = n2.GetComponent<Rigidbody2D>();

                n2.transform.localScale = new Vector3(1, 1, 1);
                n2.transform.localPosition = new Vector2(0, y);
                rigidbody2.velocity = new Vector2(0, -fallSpeed);
                break;
            case 3:
                Transform transformParent3 = note3Parent.GetComponent<Transform>();

                // GameObject n = Instantiate(note0Prefab, pos, Quaternion.Euler(0,0,0), transformParent) as GameObject;
                GameObject n3 = Instantiate(note3Prefab) as GameObject;
                n3.transform.parent = transformParent3;
                Rigidbody2D rigidbody3 = n3.GetComponent<Rigidbody2D>();

                n3.transform.localScale = new Vector3(1, 1, 1);
                n3.transform.localPosition = new Vector2(0, y);
                rigidbody3.velocity = new Vector2(0, -fallSpeed);
                break;
        }
    }
}
