using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationMenu2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private RawImage m_image;
    [SerializeField] private float m_x, m_y;

    // Update is called once per frame
    void Update()
    {
        m_image.uvRect = new Rect(m_image.uvRect.position + new Vector2(m_x, m_y)*Time.deltaTime,m_image.uvRect.size);
    }
}
