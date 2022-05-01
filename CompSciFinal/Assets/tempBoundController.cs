using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempBoundController : MonoBehaviour
{

    private Transform tf;

    private void Awake()
    {
        tf = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tf.localPosition.y < -1.5f)
        {
            tf.localPosition = new Vector2(0, Random.Range(10, 15));
            Debug.Log("Miss");
        }
    }
}
