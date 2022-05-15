using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accuracy : MonoBehaviour
{
    public Text acc;

    private void Awake()
    {
        acc.text = "100.00%";
    }

    // Update is called once per frame
    void Update()
    {
        if (Triggering.fullScore > 0)
        {
            acc.text = (((float)Triggering.score / (float)Triggering.fullScore) * 100).ToString("0.00") + "%";
        }
    }
}
