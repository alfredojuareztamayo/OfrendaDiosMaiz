using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuRotacion : MonoBehaviour
{
    public float speed;
    [SerializeField] private Renderer renderer;
    void Update()
    {
        renderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }

    // Update is called once per frame
    
}
