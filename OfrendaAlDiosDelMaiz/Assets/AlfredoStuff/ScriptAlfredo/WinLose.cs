using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public Cazuela cazuela;
    public SacrificeGeneretod SG;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void retry()
    {
        SceneManager.LoadScene("AlfredoTest");
    }
    public void Logout()
    {
        Application.Quit();
        Debug.Log("OPut");
    }
    public void backMenu()
    {
        SceneManager.LoadScene("Menu");
    }
   
    public void ganaste()
    {
        if (cazuela.S_numberPie == SG.numberPie2 && 
            cazuela.S_numberPataDePerro == SG.numberPataDePerro2 &&
            cazuela.S_numberOjos == SG.numberOjos2 && 
            cazuela.S_numberBrazo == SG.numberBrazo2 &&
            cazuela.S_numberDedo == SG.numberDedo2 &&
            cazuela.S_numberMaiz == SG.numberMaiz2 &&
            cazuela.S_numberChile == SG.numberChile2 &&
            cazuela.S_numberChapulines == SG.numberChapulines2 &&
            cazuela.S_numberChinicuiles == SG.numberChinicuiles2 &&
            cazuela.S_numberLegumbres == SG.numberLegumbres2 &&
            cazuela.S_numberFrijoles == SG.numberFrijoles2 &&
            cazuela.S_numberGusanitos == SG.numberGusanitos2 &&
            cazuela.S_numberHuitla == SG.numberHuitla2)
  
        {
            Debug.Log(cazuela.S_numberBrazo);
            Debug.Log(SG.numberBrazo2);

            SceneManager.LoadScene("Ganaste");

        }
        else
        {
            Debug.Log(cazuela.S_numberBrazo);
            Debug.Log(SG.numberBrazo2);
            SceneManager.LoadScene("Lose");
        }
    }
}
