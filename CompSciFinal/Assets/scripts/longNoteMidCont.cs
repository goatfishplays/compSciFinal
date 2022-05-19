using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longNoteMidCont : MonoBehaviour
{
    [SerializeField] private Transform tf;

    private void Start()
    {
        if(transform.parent.parent.parent.gameObject.name.Equals("Key1"))
        {
            this.GetComponent<SpriteRenderer>().color = OptionsManager.l1Image.color;
            this.transform.parent.GetComponent<SpriteRenderer>().color = OptionsManager.l1Image.color;
        }
        else if (transform.parent.parent.parent.gameObject.name.Equals("Key2"))
        {
            this.GetComponent<SpriteRenderer>().color = OptionsManager.l2Image.color;
            this.transform.parent.GetComponent<SpriteRenderer>().color = OptionsManager.l2Image.color;
        }
        else if (transform.parent.parent.parent.gameObject.name.Equals("Key3"))
        {
            this.GetComponent<SpriteRenderer>().color = OptionsManager.l3Image.color;
            this.transform.parent.GetComponent<SpriteRenderer>().color = OptionsManager.l3Image.color;
        }
        else if (transform.parent.parent.parent.gameObject.name.Equals("Key4"))
        {
            this.GetComponent<SpriteRenderer>().color = OptionsManager.l4Image.color;
            this.transform.parent.GetComponent<SpriteRenderer>().color = OptionsManager.l4Image.color;
        }
    }
    private void Update()
    {
        tf = GetComponent<Transform>();
        tf.localScale = new Vector3(1, tf.parent.localPosition.y*.8f, 1);
        tf.localPosition = -tf.parent.localPosition/2.0f;
    }
}
