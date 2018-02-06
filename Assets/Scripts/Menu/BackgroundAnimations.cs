using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MenuPackage
{

    public class BackgroundAnimations : MonoBehaviour
    {
        [SerializeField]
        private float m_rotationSpeed;

        private void FixedUpdate()
        {
            transform.Rotate(new Vector3(0, 0, m_rotationSpeed * Time.fixedDeltaTime));
        }
    }
}
