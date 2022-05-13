using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OsuLoader;

public class SongLoader : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] songs = new AudioClip[9];
    public GameObject background;
    public Sprite[] backgrounds = new Sprite[9];

    public ChartLoader chartLoader;

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        // Plays song according to song index
        audio.clip = songs[chartLoader.songIndex];
        StartCoroutine(WaitBeforePlay());
        // audio.Play();

        SpriteRenderer spriteRenderer = background.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = backgrounds[chartLoader.songIndex];
    }

    private IEnumerator WaitBeforePlay()
    {
        yield return new WaitForSeconds(ChartLoader.playDelay + ChartLoader.songOffset);

        audio.Play();
    }
}
