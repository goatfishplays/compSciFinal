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
            Triggering.fullScore += 300;
            Triggering.combo = 0;
            Debug.Log("Miss " + misses);
        }
        else if(lNote && tf.localPosition.y < -.6f)
        {
            Destroy(this);
            misses++;
            Triggering.fullScore += 300;
            Triggering.combo = 0;
            Debug.Log("Miss " + misses);
        }
        else if(lTNote && tf.localPosition.y < 0f)
        {
            Destroy(tf.gameObject.GetComponent<SpriteRenderer>());
            Destroy(tf.GetChild(0).GetComponent<SpriteRenderer>());
            if(lTNote && tf.localPosition.y < -1.25f)
            {
                Destroy(tf.parent.gameObject);
            }
        }
        else if(lTNote && tf.localPosition.y < -1.25f)
        {
            Destroy(tf.parent.gameObject);
            misses++;
            Triggering.combo = 0;
            Triggering.fullScore += 300;
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
