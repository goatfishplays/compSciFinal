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
    public static Image k1Image;
    public static Image k2Image;
    public static Image k3Image;
    public static Image k4Image;
    public static Image kd1Image;
    public static Image kd2Image;
    public static Image kd3Image;
    public static Image kd4Image;
    public static Image n1Image;
    public static Image n2Image;
    public static Image n3Image;
    public static Image n4Image;
    public static Image l1Image;
    public static Image l2Image;
    public static Image l3Image;
    public static Image l4Image;
    public static Image ln1Image;
    public static Image ln2Image;
    public static Image ln3Image;
    public static Image ln4Image;


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
        red.transform.GetChild(3).GetComponent<InputField>().text = red.value.ToString();
        green.transform.GetChild(3).GetComponent<InputField>().text = green.value.ToString();
        blue.transform.GetChild(3).GetComponent<InputField>().text = blue.value.ToString();
        alpha.transform.GetChild(3).GetComponent<InputField>().text = alpha.value.ToString();
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
        s.transform.GetChild(3).GetComponent<InputField>().text = s.value.ToString();
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
        ChartLoader.playDelay = float.Parse(sdIn.text.ToString());/*
        SceneManager.LoadScene("Game");*/
    }

    // Start is called before the first frame update
    void Awake()
    {
        fsIn.transform.GetChild(0).GetComponent<Text>().text = Triggering.fallSpeed.ToString();
        sdIn.transform.GetChild(0).GetComponent<Text>().text = ChartLoader.playDelay.ToString();
        k1Image = transform.GetChild(2).GetComponent<Image>();
        k2Image = transform.GetChild(3).GetComponent<Image>();
        k3Image = transform.GetChild(4).GetComponent<Image>();
        k4Image = transform.GetChild(5).GetComponent<Image>();
        kd1Image = transform.GetChild(6).GetComponent<Image>();
        kd2Image = transform.GetChild(7).GetComponent<Image>();
        kd3Image = transform.GetChild(8).GetComponent<Image>();
        kd4Image = transform.GetChild(9).GetComponent<Image>();
        n1Image = transform.GetChild(10).GetComponent<Image>();
        n2Image = transform.GetChild(11).GetComponent<Image>();
        n3Image = transform.GetChild(12).GetComponent<Image>();
        n4Image = transform.GetChild(13).GetComponent<Image>();
        l1Image = transform.GetChild(14).GetComponent<Image>();
        l2Image = transform.GetChild(15).GetComponent<Image>();
        l3Image = transform.GetChild(16).GetComponent<Image>();
        l4Image = transform.GetChild(17).GetComponent<Image>();
        curImInd = 2;
        Debug.Log(k1Image);
        curImage = k1Image;
        Debug.Log(curImage);
        curCol = k1Image.color;
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
