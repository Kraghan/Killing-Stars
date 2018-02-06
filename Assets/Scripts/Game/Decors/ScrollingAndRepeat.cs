using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingAndRepeat : MonoBehaviour {
    
    private Transform m_otherTransform;
    private float m_scrollingSpeed = 5;
    private float m_positionRepeat = 15;
    static private bool first = true;

    // Update is called once per frame
    void Update ()
    {
        transform.position -= new Vector3(0,m_scrollingSpeed*Time.deltaTime,0);
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("CenterTrigger"))
        {
            if (first)
                first = false;
            else
                m_otherTransform.position = new Vector3(m_otherTransform.position.x, m_positionRepeat, m_otherTransform.position.z);
        }
    }

    public void SetSpeed(float speed)
    {
        m_scrollingSpeed = speed;
    }

    public void SetRepeatPosition(float positionY)
    {
        m_positionRepeat = positionY;
    }

    public void SetOtherTransform(Transform t)
    {
        m_otherTransform = t;
    }
}
