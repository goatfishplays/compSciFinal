using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Triggering : MonoBehaviour
{
    private Inputs inputs;
    [SerializeField] private float fallSpeed = 5f;
    [SerializeField] private Color offColor = new Color(64, 128, 64);
    [SerializeField] private Color onColor = new Color(64, 255, 64);



    [SerializeField] private Collider2D k1Cd;
    [SerializeField] private SpriteRenderer sR1;
    private Collider2D[] k1Trigs = new Collider2D[10];
    private bool k1;
    private bool lastK1;

    [SerializeField] private Collider2D k2Cd;
    [SerializeField] private SpriteRenderer sR2;
    private Collider2D[] k2Trigs = new Collider2D[10];
    private bool k2;
    private bool lastK2;

    [SerializeField] private Collider2D k3Cd;
    [SerializeField] private SpriteRenderer sR3;
    private Collider2D[] k3Trigs = new Collider2D[10];
    private bool k3;
    private bool lastK3;

    [SerializeField] private Collider2D k4Cd;
    [SerializeField] private SpriteRenderer sR4;
    private Collider2D[] k4Trigs = new Collider2D[10];
    private bool k4;
    private bool lastK4;

    private int misclicks = 0;
    

    private void Awake()
    {
        inputs = new Inputs();

        inputs.buttonThings.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(inputs.buttonThings.Key1.ReadValue<float>() != 0)
        {
            k1 = true;
            sR1.color = onColor;
        }
        else
        {
            k1 = false;
            sR1.color = offColor;
        }
        if(k1 && !lastK1)
        {
            if(k1Cd.GetContacts(k1Trigs) > 0)
            {
                Collider2D downest = getDownest(k1Trigs, k1Cd.GetContacts(k1Trigs));
                Debug.Log(1 - Mathf.Abs(downest.transform.localPosition.y));
                downest.transform.localPosition = new Vector2(0, Random.Range(10, 15));
                downest.attachedRigidbody.velocity = new Vector2(0, -1 * fallSpeed);
            }
            else
            {
                misclicks++;
                Debug.Log("Misclicks" + misclicks);
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
                Debug.Log(1 - Mathf.Abs(downest.transform.localPosition.y));
                downest.transform.localPosition = new Vector2(0, Random.Range(10, 15));
                downest.attachedRigidbody.velocity = new Vector2(0, -1 * fallSpeed);
            }
            else
            {
                misclicks++;
                Debug.Log("Misclicks" + misclicks);
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
                Debug.Log(1 - Mathf.Abs(downest.transform.localPosition.y));
                downest.transform.localPosition = new Vector2(0, Random.Range(10, 15));
                downest.attachedRigidbody.velocity = new Vector2(0, -1 * fallSpeed);
            }
            else
            {
                misclicks++;
                Debug.Log("Misclicks" + misclicks);
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
                Debug.Log(1 - Mathf.Abs(downest.transform.localPosition.y));
                downest.transform.localPosition = new Vector2(0, Random.Range(10, 15));
                downest.attachedRigidbody.velocity = new Vector2(0, -1 * fallSpeed);
            }
            else
            {
                misclicks++;
                Debug.Log("Misclicks" + misclicks);
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