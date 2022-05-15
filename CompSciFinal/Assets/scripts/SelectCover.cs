using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCover : MonoBehaviour
{
    public Canvas selectedCanvas;
    public Canvas unselectedCanvas;
    private bool isSelected = false;
    Button button;
    Vector3 originalPos;
    Vector3 originalScale;

    private void Awake()
    {
        originalPos = transform.localPosition;
        originalScale = transform.localScale;
        button = GetComponent<Button>();
    }

    public void CoverSelected()
    {
        transform.LeanMoveLocal(new Vector2(-270, 0),0.5f).setEaseOutQuart();
        transform.LeanScale(new Vector3(3, 3, 3),0.5f).setEaseOutQuart();
        transform.SetParent(selectedCanvas.transform);
        button.interactable = false;
        isSelected = true;
    }

    public void CoverUnselected()
    {
        transform.SetParent(unselectedCanvas.transform);
        transform.LeanMoveLocal(originalPos, 0.5f).setEaseOutQuart();
        transform.LeanScale(originalScale, 0.5f).setEaseOutQuart();
        button.interactable = true;
        isSelected = false;
    }
}
