using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeScrolling : MonoBehaviour
{
    private List<GameObject> m_subObjects;
    [SerializeField]
    private float m_scrollingSpeed = 5;
    [SerializeField]
    private float m_repeatPosition = 16.6f;

    // Use this for initialization
    void Start()
    {
        Transform[] transforms = GetComponentsInChildren<Transform>();
        m_subObjects = new List<GameObject>();

        for (int i = 0; i < transforms.Length; ++i)
        {
            Transform t = transforms[i];

            ScrollingAndRepeat component = t.gameObject.AddComponent<ScrollingAndRepeat>();
            component.SetSpeed(m_scrollingSpeed);
            component.SetRepeatPosition(m_repeatPosition);
            int j = i + 2;
            if (j >= transforms.Length)
                j -= transforms.Length;
            component.SetOtherTransform(transforms[j]);
            t.position = new Vector3(t.position.x, i * m_repeatPosition, t.position.z);
            m_subObjects.Add(t.gameObject);
        }

    }
}
