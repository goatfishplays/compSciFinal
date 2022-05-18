using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnims : MonoBehaviour
{
    public Canvas selected;

    public void BackButtonShow()
    {
        transform.LeanMoveLocal(new Vector3(-800, 420, 0), 0.5f).setEaseOutQuart();
        
    }

    public void BackButtonHide()
    {
        transform.LeanMoveLocal(new Vector3(-800, 670, 0), 0.5f).setEaseOutQuart();
    }
}
