using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenStats : MonoBehaviour
{
    public Text score;
    public Text acc;
    public Text misses;

    private void Awake()
    {
        score.text = "Score: " + Triggering.score.ToString();
        acc.text = "Accuracy: " + (((float)Triggering.score / (float)Triggering.fullScore)*100).ToString("0.00") + "%";
        misses.text = "Misses: " + tempBoundController.misses;
    }
}
