using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCover : MonoBehaviour
{
    public void CoverSelected()
    {
        transform.LeanMoveLocal(new Vector2(-270, 0),0.5f).setEaseOutQuart();
        transform.LeanScale(new Vector3(3, 3, 3),0.5f).setEaseOutQuart();
    }
}
