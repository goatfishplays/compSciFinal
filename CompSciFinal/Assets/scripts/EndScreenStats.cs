using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenStats : MonoBehaviour
{
    public Text score;
    public Text acc;
    public Text misses;
    private string accuracy = (((float)Triggering.score / (float)Triggering.fullScore) * 100).ToString("0.00") + "%";

    private void Awake()
    {
        score.text = "Score:" + Triggering.score.ToString();
        //acc.text = "Accuracy: " + (((float)Triggering.score / (float)Triggering.fullScore)*100).ToString("0.00") + "%";
        acc.text = "Accuracy:" + accuracy;
        misses.text = "Misses:" + tempBoundController.misses;

        Debug.Log((((float)Triggering.score / (float)Triggering.fullScore) * 100).ToString("0.00") + "%");
    }
}
