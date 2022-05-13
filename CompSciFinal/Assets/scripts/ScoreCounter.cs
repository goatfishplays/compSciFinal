using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreCounter;
    public Image judgement;
    public Sprite[] judgements = new Sprite[6];

    private void Awake()
    {
        judgement.GetComponent<Image>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Triggering.score > 0)
        {
            judgement.GetComponent<Image>().enabled = true;
        }
        scoreCounter.text = Triggering.score.ToString();
        judgement.sprite = judgements[Triggering.judgement];
    }
}
