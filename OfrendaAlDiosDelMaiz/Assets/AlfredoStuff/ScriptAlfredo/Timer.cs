using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] TMP_Text tiempo;

    private float restante;
    private bool OnGoing;
    private void Awake()
    {
        restante = (min * 60) + seg;
        OnGoing = true;
    }


    void Update()
    {
        if (OnGoing)
        {
            restante -= Time.deltaTime;
            if (restante < 1)
            {
                OnGoing = true;
                SceneManager.LoadScene("Lose");
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }

    }
}
