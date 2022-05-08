using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempBoundController : MonoBehaviour
{

    private Transform tf;
    private static int misses = 0;
    [SerializeField] private bool lNote = false;
    [SerializeField] private bool lTNote = false;

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
        if(tf.localPosition.y < -.6f && (!lNote && !lTNote))
        {
            // tf.localPosition = new Vector2(0, Random.Range(10, 15));
            Destroy(this.gameObject);
            misses++;
            Debug.Log("Miss " + misses);
        }
        else if(lNote && tf.localPosition.y < -.6f)
        {
            Destroy(this);
            misses++;
            Debug.Log("Miss " + misses);
        }
        else if(lTNote && tf.localPosition.y < -.25f)
        {
            Destroy(tf.parent.gameObject);
            misses++;
            Debug.Log("Miss " + misses);
            
        }
        else if(lTNote && tf.position.y < -6)
        {
            Destroy(tf.parent.gameObject);
        }
    }

    public bool isLong()
    {
        return lNote;
    }

    public bool isTopLong()
    {
        return lTNote;
    }

    public static int getMisses()
    {
        return misses;
    }

    public static void incMisses()
    {
        misses++;
    }
}
