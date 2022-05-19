using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCover : MonoBehaviour
{
    public Canvas selectedCanvas;
    public Canvas unselectedCanvas;
    Button button;
    Vector3 originalPos;
    Vector3 originalScale;
    List<Button> diffButtons;

    private void Awake()
    {
        originalPos = transform.localPosition;
        originalScale = transform.localScale;
        button = GetComponent<Button>();

        /*for (int i = 0; i < transform.childCount; i++)
        {
            Button button = GetComponentInChildren<Button>();
            diffButtons.Add(button);
        }
        foreach(Button button in diffButtons)
        {
            button.interactable = false;
            ColorBlock colorBlock = button.GetComponent<Button>().colors;
            colorBlock.normalColor = new Color(255,255,255,0);
            colorBlock.disabledColor = new Color(255, 255, 255, 0);
        }*/
    }

    public void CoverSelected()
    {
        transform.LeanMoveLocal(new Vector2(-300, 0),0.5f).setEaseOutQuart();
        transform.LeanScale(new Vector3(3, 3, 3),0.5f).setEaseOutQuart();
        transform.SetParent(selectedCanvas.transform);
        button.interactable = false;
    }

    public void CoverUnselected()
    {
        transform.SetParent(unselectedCanvas.transform);
        transform.LeanMoveLocal(originalPos, 0.5f).setEaseOutQuart();
        transform.LeanScale(originalScale, 0.5f).setEaseOutQuart();
        button.interactable = true;
    }
}
