using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecermenu2 : MonoBehaviour
{
    public GameObject menuIngredientes;
    public void aparecerMenu()
    {
        menuIngredientes.SetActive(true);
    }
    public void DesaparecerMenu()
    {
        menuIngredientes.SetActive(false);
    }
}
