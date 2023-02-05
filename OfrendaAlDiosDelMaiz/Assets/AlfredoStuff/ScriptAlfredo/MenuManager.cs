using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject HowToP;
    public GameObject Menu;
    public GameObject Creditos;
    public void StartGame()
    {
        SceneManager.LoadScene("AlfredoTest");
    }
    public void HowToPlay()
    {
       HowToP.SetActive(true);
        Menu.SetActive(false);
    } 
    public void Logout()
    {
        Application.Quit();
        Debug.Log("Me sali");
    }
    public void returnMenu()
    {
        HowToP.SetActive(false);
        Menu.SetActive(true);
    }

    public void CreditosMenu()
    {
        Creditos.SetActive(true);
        Menu.SetActive(false);
    }
    public void returnMenuCreditod()
    {
        Creditos.SetActive(false);
        Menu.SetActive(true);
    }
}
