using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longNoteMidCont : MonoBehaviour
{
    [SerializeField] private Transform tf;
    private void Update()
    {
        tf = GetComponent<Transform>();
        tf.localScale = new Vector3(1, tf.parent.localPosition.y*.8f, 1);
        tf.localPosition = -tf.parent.localPosition/2.0f;
    }
}
