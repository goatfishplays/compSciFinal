using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsManager : MonoBehaviour
{
    [SerializeField] private InputField fsIn;
    [SerializeField] private InputField sdIn;
    [SerializeField] private Slider red;
    [SerializeField] private Slider green;
    [SerializeField] private Slider blue;
    [SerializeField] private Slider alpha;
    public Image k1Image;
    public Image k2Image;
    public Image k3Image;
    public Image k4Image;
    public Image kd1Image;
    public Image kd2Image;
    public Image kd3Image;
    public Image kd4Image;
    public Image n1Image;
    public Image n2Image;
    public Image n3Image;
    public Image n4Image;
    public Image l1Image;
    public Image l2Image;
    public Image l3Image;
    public Image l4Image;
    public Image ln1Image;
    public Image ln2Image;
    public Image ln3Image;
    public Image ln4Image;
    public Color32 k1Color;
    public Color32 k2Color;
    public Color32 k3Color;
    public Color32 k4Color;
    public Color32 kd1Color;
    public Color32 kd2Color;
    public Color32 kd3Color;
    public Color32 kd4Color;
    public Color32 n1Color;
    public Color32 n2Color;
    public Color32 n3Color;
    public Color32 n4Color;
    public Color32 l1Color;
    public Color32 l2Color;
    public Color32 l3Color;
    public Color32 l4Color;


    private Image curImage;
    private Color32 curCol;
    private int curImInd;


    public void select(Button cBut)
    {
        curImInd = cBut.transform.GetSiblingIndex();
        curImage = cBut.image;
        curCol = curImage.color;
        red.value = curCol.r;
        green.value = curCol.g;
        blue.value = curCol.b;
        alpha.value = curCol.a;
    }

    public void colorChange(Slider s)
    {
        switch (s.transform.GetSiblingIndex())
        {
            case 18:
                curCol.r = (byte)s.value;
                curImage.color = curCol;
                if(curImage.transform.childCount > 0)
                {
                    curImage.transform.GetChild(0).GetComponent<Image>().color = curCol;
                }
                break;
            case 19:
                curCol.g = (byte)s.value;
                curImage.color = curCol;
                if (curImage.transform.childCount > 0)
                {
                    curImage.transform.GetChild(0).GetComponent<Image>().color = curCol;
                }
                break;
            case 20:
                curCol.b = (byte)s.value;
                curImage.color = curCol;
                if (curImage.transform.childCount > 0)
                {
                    curImage.transform.GetChild(0).GetComponent<Image>().color = curCol;
                }
                break;
            case 21:
                curCol.a = (byte)s.value;
                curImage.color = curCol;
                if (curImage.transform.childCount > 0)
                {
                    curImage.transform.GetChild(0).GetComponent<Image>().color = curCol;
                }
                break;
            default:
                Debug.Log("hat");
                break;
        }
        red.transform.GetChild(3).GetChild(1).GetComponent<Text>().text = red.value.ToString();
        green.transform.GetChild(3).GetChild(1).GetComponent<Text>().text = green.value.ToString();
        blue.transform.GetChild(3).GetChild(1).GetComponent<Text>().text = blue.value.ToString();
        alpha.transform.GetChild(3).GetChild(1).GetComponent<Text>().text = alpha.value.ToString();
    }

    public void colorChange2(InputField iF)
    {
        if(iF.text.Equals(""))
        {
            iF.text = 0.ToString();
            return;
        }
        int val = int.Parse(iF.text.ToString());
        if (val < 0)
        {
            val = 0;
            iF.text = 0.ToString();
        }
        else if(val > 255)
        {
            val = 255;
            iF.text = 255.ToString();
        }
        iF.transform.parent.GetComponent<Slider>().value = val;
        switch(iF.transform.parent.GetSiblingIndex())
        {
            case 18:
                curCol.r = byte.Parse(iF.text.ToString());
                curImage.color = curCol;
                if (curImage.transform.childCount > 0)
                {
                    curImage.transform.GetChild(0).GetComponent<Image>().color = curCol;
                }
                break;
            case 19:
                curCol.g = byte.Parse(iF.text.ToString());
                curImage.color = curCol;
                if (curImage.transform.childCount > 0)
                {
                    curImage.transform.GetChild(0).GetComponent<Image>().color = curCol;
                }
                break;
            case 20:
                curCol.b = byte.Parse(iF.text.ToString());
                curImage.color = curCol;
                if (curImage.transform.childCount > 0)
                {
                    curImage.transform.GetChild(0).GetComponent<Image>().color = curCol;
                }
                break;
            case 21:
                curCol.a = byte.Parse(iF.text.ToString());
                curImage.color = curCol;
                if (curImage.transform.childCount > 0)
                {
                    curImage.transform.GetChild(0).GetComponent<Image>().color = curCol;
                }
                break;
            default:
                Debug.Log("hat");
                break;
        }
    }

    public void fsInChanged()
    {
        float fs = float.Parse(fsIn.text.ToString());
        if(fs <= 0)
        {
            fs = 0.001f;
            fsIn.text = fs.ToString();
        }
        Triggering.fallSpeed = fs;
    }

    public void sdInChanged()
    {
        ChartLoader.playDelay = float.Parse(sdIn.text.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        fsIn.transform.GetChild(0).GetComponent<Text>().text = Triggering.fallSpeed.ToString();
        sdIn.transform.GetChild(0).GetComponent<Text>().text = ChartLoader.playDelay.ToString();
        k1Color = k1Image.color;
        k2Color = k2Image.color;
        k3Color = k3Image.color;
        k4Color = k4Image.color;
        kd1Color = kd1Image.color;
        kd2Color = kd2Image.color;
        kd3Color = kd3Image.color;
        kd4Color = kd4Image.color;
        n1Color = n1Image.color;
        n2Color = n2Image.color;
        n3Color = n3Image.color;
        n4Color = n4Image.color;
        l1Color = l1Image.color;
        l2Color = l2Image.color;
        l3Color = l3Image.color;
        l4Color = l4Image.color;
        ln1Image.color = l1Color;
        ln2Image.color = l2Color;
        ln3Image.color = l3Color;
        ln4Image.color = l4Color;

        curImInd = 2;
        curImage = k1Image;
        curCol = k1Color;
        red.value = curCol.r;
        green.value = curCol.g;
        blue.value = curCol.b;
        alpha.value = curCol.a;
        red.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = red.value.ToString();
        green.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = green.value.ToString();
        blue.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = blue.value.ToString();
        alpha.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = alpha.value.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
