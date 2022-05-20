using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffButtonAnims : MonoBehaviour
{
    public void showDiffButtons()
    {
        transform.LeanMoveLocal(new Vector2(0, 0), 0.5f).setEaseOutQuart();
    }

    public void hideDiffButtons()
    {
        transform.LeanMoveLocal(new Vector2(2000, 0), 1f).setEaseOutQuart();
    }
}
