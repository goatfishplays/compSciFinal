using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempBoundController : MonoBehaviour
{

    private Transform tf;
    [SerializeField] private bool lNote = false;

    private void Awake()
    {
        tf = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(tf.position.y < -4f)
        {
            // tf.localPosition = new Vector2(0, Random.Range(10, 15));
            Destroy(this);
            Debug.Log("Miss");
        }
    }

    public bool isLong()
    {
        return lNote;
    }
}
