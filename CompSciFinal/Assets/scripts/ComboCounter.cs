using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboCounter : MonoBehaviour
{

    public Text comboCounter;

    private void Awake()
    {
        comboCounter = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        comboCounter.text = Triggering.combo.ToString();
    }
}
