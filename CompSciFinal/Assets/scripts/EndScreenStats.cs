using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenStats : MonoBehaviour
{
    public Text score;
    public Text acc;
    public Text misses;
    private double accuracy = (((float)Triggering.score / (float)Triggering.fullScore) * 100);
    public Sprite[] ranks = new Sprite[5];
    public Image rankImg;

    private void Awake()
    {
        score.text = "Score:" + Triggering.score.ToString();
        //acc.text = "Accuracy: " + (((float)Triggering.score / (float)Triggering.fullScore)*100).ToString("0.00") + "%";
        acc.text = "Accuracy:" + accuracy.ToString("0.00");
        misses.text = "Misses:" + tempBoundController.misses;

        if (accuracy < 60f)
        {
            rankImg.sprite = ranks[4];
        }
        else if (accuracy < 70f)
        {
            rankImg.sprite = ranks[3];
        }
        else if (accuracy < 80f)
        {
            rankImg.sprite = ranks[2];
        }
        else if (accuracy < 90f)
        {
            rankImg.sprite = ranks[1];
        }
        else
        {
            rankImg.sprite = ranks[0];
        }

        Debug.Log((((float)Triggering.score / (float)Triggering.fullScore) * 100).ToString("0.00") + "%");
    }
}
