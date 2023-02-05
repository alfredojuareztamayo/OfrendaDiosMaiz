using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
//using System;

public class SacrificeGeneretod : MonoBehaviour
{
    public TMP_Text m_Recepi;
    public TMP_Text m_ingredients;
    public int textRandom;
    public int numberPie1, numberPataDePerro1, numberOjos1, numberBrazo1, numberDedo1, numberMaiz1, numberChile1, numberChapulines1, numberChinicuiles1, numberLegumbres1,
    numberFrijoles1, numberGusanitos1, numberHuitla1;
    public string numberPie2, numberPataDePerro2, numberOjos2, numberBrazo2, numberDedo2, numberMaiz2, numberChile2, numberChapulines2, numberChinicuiles2, numberLegumbres2,
   numberFrijoles2, numberGusanitos2, numberHuitla2;
    public Cazuela Cazuela;
    void Start()
    {
        textRandom = -1;
        GenereteTextNumber();
        
    }

    // Update is called once per frame
    void Update()
    {
        GenereteText();
        generarIngredientes();
    }
    public void GenereteTextNumber()
    {
        textRandom = Random.Range(0, 1);
        numberPie1= Random.Range(0,5);
        numberPataDePerro1= Random.Range(0,5);
        numberBrazo1 = Random.Range(0,5);
        numberDedo1 = Random.Range(0,5);
        numberMaiz1 = Random.Range(0,5);
        numberChile1 = Random.Range(0,5);
        numberChapulines1 = Random.Range(0,5);
        numberChinicuiles1 = Random.Range(0,5);
        numberLegumbres1 = Random.Range(0,5);
        numberFrijoles1 = Random.Range(0,5);
        numberGusanitos1 = Random.Range(0,5);
        numberHuitla1 = Random.Range(0,5);
        numberOjos1= Random.Range(0,5);
        numberPie2 = numberPie1.ToString();
        numberPataDePerro2= numberPataDePerro1.ToString();
        numberBrazo2 = numberBrazo1.ToString();
        numberDedo2= numberDedo1.ToString();
        numberMaiz2 = numberMaiz1.ToString();
        numberChile2 = numberChile1.ToString();
        numberChapulines2 = numberChapulines1.ToString();
        numberChinicuiles2 = numberChinicuiles1.ToString();
        numberLegumbres2= numberLegumbres1.ToString();
        numberFrijoles2 = numberFrijoles1.ToString();
        numberGusanitos2 = numberGusanitos1.ToString();
        numberHuitla2 = numberHuitla1.ToString();
        numberOjos2= numberOjos1.ToString();

    }
    public void GenereteText()
    {
        switch (textRandom)
        {
            case -1:
                m_Recepi.text = "Quiero una sacrificio";
                break;
            case 0:
                m_Recepi.text = "Quiero una Pozole";
                break;
          
        }
    }
    public void generarIngredientes()
    {
        switch (textRandom)
        {
            case -1:
                m_ingredients.text = " ";
                break;
                case 0:
                m_ingredients.text = "Necesitas\n" + Cazuela.S_numberPie + "/" + numberPie2 + "Pies\n"
                    + Cazuela.S_numberPataDePerro + "/" + numberPataDePerro2 + "Patas de Perro\n"
                     + Cazuela.S_numberBrazo + "/" + numberBrazo2 + "Brazos\n"
                     + Cazuela.S_numberDedo + "/" + numberDedo2 + "Dedos\n"
                      + Cazuela.S_numberOjos + "/" + numberOjos2 + "Ojos\n"
                     + Cazuela.S_numberMaiz + "/" + numberMaiz2 + "Maiz\n"
                     + Cazuela.S_numberChile + "/" + numberChile2 + "Chile\n"
                     + Cazuela.S_numberChapulines + "/" + numberChapulines2 + "Chapulines\n"
                     + Cazuela.S_numberChinicuiles + "/" + numberChinicuiles2 + "Chinicuiles\n"
                     + Cazuela.S_numberLegumbres + "/" + numberLegumbres2 + "Legumbres\n"
                     + Cazuela.S_numberFrijoles + "/" + numberFrijoles2 + "Frijoles\n"
                     + Cazuela.S_numberGusanitos + "/" + numberGusanitos2 + "Gusanitos\n"
                     + Cazuela.S_numberHuitla + "/" + numberHuitla2 + "Huitlacoche\n";


                break;
        }
    }
}
