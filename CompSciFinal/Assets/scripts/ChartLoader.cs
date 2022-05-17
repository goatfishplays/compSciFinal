using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OsuLoader;

public class ChartLoader : MonoBehaviour
{
    public int songIndex;
    public int diffIndex;
    public GameObject clickManager;
    public GameObject note0Prefab;
    public GameObject lNote0Prefab;
    public GameObject lNote0End;
    public GameObject note0Parent;
    public GameObject note1Prefab;
    public GameObject lNote1Prefab;
    public GameObject note1Parent;
    public GameObject note2Prefab;
    public GameObject lNote2Prefab;
    public GameObject note2Parent;
    public GameObject note3Prefab;
    public GameObject lNote3Prefab;
    public GameObject note3Parent;
    private BeatMap beatMap;
    private int tick = 0;

    public static float playDelay = 3f;
    public static float songOffset;

    private void Awake()
    {
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
            SpawnSingleNote(note);
        }
        foreach (LongNote longNote in beatMap.LongNotes)
        {
            SpawnLongNote(longNote);
        }
    }

    public void LoadFile()
    {
        string song = "";
        switch (songIndex)
        {
            case 0:
                song = "306191 Masayoshi Minoshima ft nomico - Bad apple";
                break;
            case 1:
                song = "466946 t+pazolite - Call me it (500 Tortures)";
                break;
            case 2:
                song = "476221 t+pazolite - CENSORED!!";
                break;
            case 3:
                song = "173612 xi - FREEDOM DiVE";
                break;
            case 4:
                song = "639647 Camellia - GHOST";
                break;
            case 5:
                song = "1224617 Kobaryo - Invisible Frenzy";
                break;
            case 6:
                song = "484327 t+pazolite - Pumpin' Junkies";
                break;
            case 7:
                song = "523735 Kurokotei - Scattered Faith";
                break;
            case 8:
                song = "915764 Kobaryo - Villain Virus [feat Camellia]";
                break;
            default:
                Debug.Log("songIndex is higher than number of songs");
                break;
        }

        // Sets a path for all .osu files for 1 song
        string path = System.IO.Directory.GetCurrentDirectory().Replace("CompSciFinal", "osuMaps\\") + song;
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
            songOffset = beatMap.AudioLeadIn;
        }

        
        Debug.Log(beatMap.SingleNotes.Count);
        Debug.Log(files[diffIndex]);
        Debug.Log(beatMap.LongNotes[0].Column);
    }

    private void SpawnSingleNote(Note note)
    {
        int column = note.Column;
        float time = note.Time;
        float fallSpeed = Triggering.fallSpeed;

        float y = fallSpeed * time / 1000 + fallSpeed*playDelay;

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

    private void SpawnLongNote (LongNote longNote)
    {
        int column = longNote.Column;
        float startTime = longNote.StartTime;
        float endTime = longNote.EndTime;
        float fallSpeed = Triggering.fallSpeed;

        float yStart = fallSpeed * startTime / 1000 + fallSpeed * playDelay;
        float yEnd = fallSpeed * endTime / 1000 + fallSpeed * playDelay;
        float yRealEnd = yEnd - yStart;

        switch (column)
        {
            case 0:
                Transform transformParent0 = note0Parent.GetComponent<Transform>();
                // Transform transformChild0 = lNote0Prefab.GetComponentInChildren<Transform>();

                GameObject lN0 = Instantiate(lNote0Prefab) as GameObject;
                lN0.transform.parent = transformParent0;
                Rigidbody2D rigidbody0 = lN0.GetComponent<Rigidbody2D>();

                lN0.transform.localScale = new Vector3(1, 1, 1);
                lN0.transform.localPosition = new Vector2(0, yStart);
                // transformChild0.localPosition = new Vector2(0, yEnd);
                lN0.transform.GetChild(0).localPosition = new Vector2(0, yRealEnd);
                rigidbody0.velocity = new Vector2(0, -fallSpeed);
                break;
            case 1:
                Transform transformParent1 = note1Parent.GetComponent<Transform>();
                // Transform transformChild0 = lNote0Prefab.GetComponentInChildren<Transform>();

                GameObject lN1 = Instantiate(lNote1Prefab) as GameObject;
                lN1.transform.parent = transformParent1;
                Rigidbody2D rigidbody1 = lN1.GetComponent<Rigidbody2D>();

                lN1.transform.localScale = new Vector3(1, 1, 1);
                lN1.transform.localPosition = new Vector2(0, yStart);
                // transformChild0.localPosition = new Vector2(0, yEnd);
                lN1.transform.GetChild(0).localPosition = new Vector2(0, yRealEnd);
                rigidbody1.velocity = new Vector2(0, -fallSpeed);
                break;
            case 2:
                Transform transformParent2 = note2Parent.GetComponent<Transform>();
                // Transform transformChild0 = lNote0Prefab.GetComponentInChildren<Transform>();

                GameObject lN2 = Instantiate(lNote2Prefab) as GameObject;
                lN2.transform.parent = transformParent2;
                Rigidbody2D rigidbody2 = lN2.GetComponent<Rigidbody2D>();

                lN2.transform.localScale = new Vector3(1, 1, 1);
                lN2.transform.localPosition = new Vector2(0, yStart);
                // transformChild0.localPosition = new Vector2(0, yEnd);
                lN2.transform.GetChild(0).localPosition = new Vector2(0, yRealEnd);
                rigidbody2.velocity = new Vector2(0, -fallSpeed);
                break;
            case 3:
                Transform transformParent3 = note3Parent.GetComponent<Transform>();
                // Transform transformChild0 = lNote0Prefab.GetComponentInChildren<Transform>();

                GameObject lN3 = Instantiate(lNote0Prefab) as GameObject;
                lN3.transform.parent = transformParent3;
                Rigidbody2D rigidbody3 = lN3.GetComponent<Rigidbody2D>();

                lN3.transform.localScale = new Vector3(1, 1, 1);
                lN3.transform.localPosition = new Vector2(0, yStart);
                // transformChild0.localPosition = new Vector2(0, yEnd);
                lN3.transform.GetChild(0).localPosition = new Vector2(0, yRealEnd);
                rigidbody3.velocity = new Vector2(0, -fallSpeed);
                break;
        }
    }
}
