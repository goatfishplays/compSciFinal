using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OsuLoader;

public class SongLoader : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] songs = new AudioClip[7];
    public GameObject background;
    public Sprite[] backgrounds = new Sprite[7];

    public ChartLoader chartLoader;

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        // Plays song according to song index
        audio.clip = songs[chartLoader.songIndex];
        audio.Play();

        SpriteRenderer spriteRenderer = background.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = backgrounds[chartLoader.songIndex];
    }
}
