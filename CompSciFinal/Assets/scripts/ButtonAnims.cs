using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnims : MonoBehaviour
{
    public void ButtonShow()
    {
        transform.LeanMoveLocal(new Vector3(-800, 420, 0), 0.5f).setEaseOutQuart();
        
    }

    public void ButtonHide()
    {
        transform.LeanMoveLocal(new Vector3(-800, 670, 0), 0.5f).setEaseOutQuart();
    }
}
