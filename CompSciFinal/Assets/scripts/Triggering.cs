using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Triggering : MonoBehaviour
{
    private Inputs inputs;
    public static float fallSpeed = 5f;
    [SerializeField] private Color offColor = new Color(64, 128, 64);
    [SerializeField] private Color onColor = new Color(64, 255, 64);


    [SerializeField] private Collider2D k1Cd;
    [SerializeField] private SpriteRenderer sR1;
    public GameObject note0;
    private Collider2D[] k1Trigs = new Collider2D[10];
    private bool k1;
    private bool lastK1;
    private bool holdingK1 = false;

    [SerializeField] private Collider2D k2Cd;
    [SerializeField] private SpriteRenderer sR2;
    public GameObject note1;
    private Collider2D[] k2Trigs = new Collider2D[10];
    private bool k2;
    private bool lastK2;
    private bool holdingK2 = false;

    [SerializeField] private Collider2D k3Cd;
    [SerializeField] private SpriteRenderer sR3;
    public GameObject note2;
    private Collider2D[] k3Trigs = new Collider2D[10];
    private bool k3;
    private bool lastK3;
    private bool holdingK3 = false;

    [SerializeField] private Collider2D k4Cd;
    [SerializeField] private SpriteRenderer sR4;
    public GameObject note3;
    private Collider2D[] k4Trigs = new Collider2D[10];
    private bool k4;
    private bool lastK4;
    private bool holdingK4 = false;

    public static int combo = 0;
    public static int misclicks = 0;
    public static int score = 0;
    public static int fullScore = 0;
    public static int judgement = 0;

    private void Awake()
    {
        inputs = new Inputs();

        inputs.buttonThings.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (inputs.buttonThings.Key1.ReadValue<float>() != 0)
        {
            k1 = true;
            sR1.color = onColor;
        }
        else
        {
            k1 = false;
            sR1.color = offColor;
        }
        if (k1 && !lastK1)
        {
            if (k1Cd.GetContacts(k1Trigs) > 0)
            {
                Collider2D downest = getDownest(k1Trigs, k1Cd.GetContacts(k1Trigs));
                // downest.transform.localPosition = new Vector2(0, Random.Range(10, 15));
                if (downest.GetComponent<tempBoundController>() != null && !downest.GetComponent<tempBoundController>().isTopLong())
                {
                    Debug.Log(1 - Mathf.Abs(downest.transform.localPosition.y));
                    if(1 - Mathf.Abs(downest.transform.localPosition.y) < 0.1f)
                    {
                        score += 0;
                        judgement = 0;
                        combo = 0;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.15f)
                    {
                        score += 50;
                        judgement = 1;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.25f)
                    {
                        score += 100;
                        judgement = 2;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.5f)
                    {
                        score += 200;
                        judgement = 3;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.75f)
                    {
                        score += 300;
                        judgement = 4;
                        combo++;
                    }
                    else
                    {
                        score += 300;
                        judgement = 5;
                        combo++;
                    }
                    fullScore += 300;
                    tempBoundController longDet = downest.GetComponent<tempBoundController>();
                    if (!longDet.isLong())
                    {
                        Destroy(downest.gameObject);
                    }
                    else
                    {
                        holdingK1 = true;
                        Transform childtf = downest.transform.GetChild(0);
                        childtf.localPosition += downest.transform.localPosition;
                        downest.attachedRigidbody.simulated = false;
                        downest.transform.localPosition = new Vector3(0, 0, 0);
                        childtf.GetComponent<Rigidbody2D>().velocity = downest.attachedRigidbody.velocity;
                        childtf.GetComponent<Rigidbody2D>().simulated = true;

                    }
                }
            }
            else
            {
                misclicks++;
                // Debug.Log("Misclicks" + misclicks);
            }
        }
        if (holdingK1 && getDownest(k1Trigs, k1Cd.GetContacts(k1Trigs)).transform.localPosition.y < -0.25)
        {
            holdingK1 = false;
        }
        if (holdingK1 && !k1 && lastK1)
        {
            holdingK1 = false;
            Collider2D downest = getDownest(k1Trigs, k1Cd.GetContacts(k1Trigs));
            //when actually getitng the values we need to get a filter for if the value is <0 we count as a miss\
            float score = 1 - Mathf.Abs(downest.transform.parent.localPosition.y + downest.transform.localPosition.y);
            if (score > 0)
            {
                Debug.Log(score);
                Destroy(downest.transform.parent.gameObject);
            }
            else
            {
                downest.attachedRigidbody.simulated = true;
                Destroy(downest.GetComponent<Collider2D>());
            }
        }


        if (inputs.buttonThings.Key2.ReadValue<float>() != 0)
        {
            k2 = true;
            sR2.color = onColor;
        }
        else
        {
            k2 = false;
            sR2.color = offColor;
        }
        if (k2 && !lastK2)
        {
            if (k2Cd.GetContacts(k2Trigs) > 0)
            {
                Collider2D downest = getDownest(k2Trigs, k2Cd.GetContacts(k2Trigs));
                // downest.transform.localPosition = new Vector2(0, Random.Range(20, 25));
                if (downest.GetComponent<tempBoundController>() != null && !downest.GetComponent<tempBoundController>().isTopLong())
                {
                    Debug.Log(1 - Mathf.Abs(downest.transform.localPosition.y));
                    if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.1f)
                    {
                        score += 0;
                        judgement = 0;
                        combo = 0;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.15f)
                    {
                        score += 50;
                        judgement = 1;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.25)
                    {
                        score += 100;
                        judgement = 2;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.5f)
                    {
                        score += 200;
                        judgement = 3;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.75f)
                    {
                        score += 300;
                        judgement = 4;
                        combo++;
                    }
                    else
                    {
                        score += 300;
                        judgement = 5;
                        combo++;
                    }
                    fullScore += 300;
                    tempBoundController longDet = downest.GetComponent<tempBoundController>();
                    if (!longDet.isLong())
                    {
                        Destroy(downest.gameObject);
                    }
                    else
                    {
                        holdingK2 = true;
                        Transform childtf = downest.transform.GetChild(0);
                        childtf.localPosition += downest.transform.localPosition;
                        downest.attachedRigidbody.simulated = false;
                        downest.transform.localPosition = new Vector3(0, 0, 0);
                        childtf.GetComponent<Rigidbody2D>().velocity = downest.attachedRigidbody.velocity;
                        childtf.GetComponent<Rigidbody2D>().simulated = true;

                    }
                }
            }
            else
            {
                misclicks++;
                // Debug.Log("Misclicks" + misclicks);
            }
        }
        if (holdingK2 && getDownest(k2Trigs, k2Cd.GetContacts(k2Trigs)).transform.localPosition.y < -0.25)
        {
            holdingK2 = false;
        }
        if (holdingK2 && !k2 && lastK2)
        {
            holdingK2 = false;
            Collider2D downest = getDownest(k2Trigs, k2Cd.GetContacts(k2Trigs));
            //when actually getitng the values we need to get a filter for if the value is <0 we count as a miss\
            float score = 1 - Mathf.Abs(downest.transform.parent.localPosition.y + downest.transform.localPosition.y);
            if (score > 0)
            {
                Debug.Log(score);
                Destroy(downest.transform.parent.gameObject);
            }
            else
            {
                downest.attachedRigidbody.simulated = true;
                Destroy(downest.GetComponent<Collider2D>());
            }
        }



        if (inputs.buttonThings.Key3.ReadValue<float>() != 0)
        {
            k3 = true;
            sR3.color = onColor;
        }
        else
        {
            k3 = false;
            sR3.color = offColor;
        }
        if (k3 && !lastK3)
        {
            if (k3Cd.GetContacts(k3Trigs) > 0)
            {
                Collider2D downest = getDownest(k3Trigs, k3Cd.GetContacts(k3Trigs));
                // downest.transform.localPosition = new Vector2(0, Random.Range(30, 35));
                if (downest.GetComponent<tempBoundController>() != null && !downest.GetComponent<tempBoundController>().isTopLong())
                {
                    Debug.Log(1 - Mathf.Abs(downest.transform.localPosition.y));
                    if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.1f)
                    {
                        score += 0;
                        judgement = 0;
                        combo = 0;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.15f)
                    {
                        score += 50;
                        judgement = 1;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.25f)
                    {
                        score += 100;
                        judgement = 2;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.5f)
                    {
                        score += 200;
                        judgement = 3;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.75f)
                    {
                        score += 300;
                        judgement = 4;
                        combo++;
                    }
                    else
                    {
                        score += 300;
                        judgement = 5;
                        combo++;
                    }
                    fullScore += 300;
                    tempBoundController longDet = downest.GetComponent<tempBoundController>();
                    if (!longDet.isLong())
                    {
                        Destroy(downest.gameObject);
                    }
                    else
                    {
                        holdingK3 = true;
                        Transform childtf = downest.transform.GetChild(0);
                        childtf.localPosition += downest.transform.localPosition;
                        downest.attachedRigidbody.simulated = false;
                        downest.transform.localPosition = new Vector3(0, 0, 0);
                        childtf.GetComponent<Rigidbody2D>().velocity = downest.attachedRigidbody.velocity;
                        childtf.GetComponent<Rigidbody2D>().simulated = true;

                    }
                }
            }
            else
            {
                misclicks++;
                // Debug.Log("Misclicks" + misclicks);
            }
        }
        if (holdingK3 && getDownest(k3Trigs, k3Cd.GetContacts(k3Trigs)).transform.localPosition.y < -0.25)
        {
            holdingK3 = false;
        }
        if (holdingK3 && !k3 && lastK3)
        {
            holdingK3 = false;
            Collider2D downest = getDownest(k3Trigs, k3Cd.GetContacts(k3Trigs));
            //when actually getitng the values we need to get a filter for if the value is <0 we count as a miss\
            float score = 1 - Mathf.Abs(downest.transform.parent.localPosition.y + downest.transform.localPosition.y);
            if (score > 0)
            {
                Debug.Log(score);
                Destroy(downest.transform.parent.gameObject);
            }
            else
            {
                downest.attachedRigidbody.simulated = true;
                Destroy(downest.GetComponent<Collider2D>());
            }
        }



        if (inputs.buttonThings.Key4.ReadValue<float>() != 0)
        {
            k4 = true;
            sR4.color = onColor;
        }
        else
        {
            k4 = false;
            sR4.color = offColor;
        }
        if (k4 && !lastK4)
        {
            if (k4Cd.GetContacts(k4Trigs) > 0)
            {
                Collider2D downest = getDownest(k4Trigs, k4Cd.GetContacts(k4Trigs));
                // downest.transform.localPosition = new Vector2(0, Random.Range(40, 45));
                if (downest.GetComponent<tempBoundController>() != null && !downest.GetComponent<tempBoundController>().isTopLong())
                {
                    Debug.Log(1 - Mathf.Abs(downest.transform.localPosition.y));
                    if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.1f)
                    {
                        score += 0;
                        judgement = 0;
                        combo = 0;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.15f)
                    {
                        score += 50;
                        judgement = 1;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.25f)
                    {
                        score += 100;
                        judgement = 2;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.5f)
                    {
                        score += 200;
                        judgement = 3;
                        combo++;
                    }
                    else if (1 - Mathf.Abs(downest.transform.localPosition.y) < 0.75f)
                    {
                        score += 300;
                        judgement = 4;
                        combo++;
                    }
                    else
                    {
                        score += 300;
                        judgement = 5;
                        combo++;
                    }
                    fullScore += 300;
                    tempBoundController longDet = downest.GetComponent<tempBoundController>();
                    if (!longDet.isLong())
                    {
                        Destroy(downest.gameObject);
                    }
                    else
                    {
                        holdingK4 = true;
                        Transform childtf = downest.transform.GetChild(0);
                        childtf.localPosition += downest.transform.localPosition;
                        downest.attachedRigidbody.simulated = false;
                        downest.transform.localPosition = new Vector3(0, 0, 0);
                        childtf.GetComponent<Rigidbody2D>().velocity = downest.attachedRigidbody.velocity;
                        childtf.GetComponent<Rigidbody2D>().simulated = true;

                    }
                }
            }
            else
            {
                misclicks++;
                // Debug.Log("Misclicks" + misclicks);
            }
        }
        if(holdingK4 && getDownest(k4Trigs, k4Cd.GetContacts(k4Trigs)).transform.localPosition.y < -0.25)
        {
            holdingK4 = false;
        }
        if (holdingK4 && !k4 && lastK4)
        {
            holdingK4 = false;
            Collider2D downest = getDownest(k4Trigs, k4Cd.GetContacts(k4Trigs));
            //when actually getitng the values we need to get a filter for if the value is <0 we count as a miss\
            float score = 1 - Mathf.Abs(downest.transform.parent.localPosition.y + downest.transform.localPosition.y);
            if(score > 0)
            {
                Debug.Log(score);
                Destroy(downest.transform.parent.gameObject);
            }
            else
            {
                downest.attachedRigidbody.simulated = true;
                Destroy(downest.GetComponent<Collider2D>());
            }
        }


        lastK1 = k1;
        lastK2 = k2;
        lastK3 = k3;
        lastK4 = k4;
    }

    private Collider2D getDownest(Collider2D[] cds, int numCds)
    {
        int downestInd = 0;
        for(int i = 1; i < numCds; i++)
        {
            if(cds[i].transform.localPosition.y < cds[downestInd].transform.localPosition.y)
            {
                downestInd = i;
            }
        }
        return cds[downestInd];
    }
}
