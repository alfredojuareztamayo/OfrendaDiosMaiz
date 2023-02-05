using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cazuela : MonoBehaviour
{
    //Para los sprites bonitos/ ingredientes 
    [Header("Ingredientes")]
    public GameObject Pie, pataDePerro, Ojos, Brazo, Dedo, Maiz, Chile, Chapulines, Chinicuiles, Legumbres, Frijoles, Gusanitos, Huitlacoche;
    //pido los vectores de los ingredientes, para resetearlos
    private Vector3 posPie, posPataDePerro, posOjos, posBrazo, posDedo, posMaiz, posChile, posChapulines, posChinicuiles, posLegumbres, posFrijoles, posGusanitos,posHuitlacoche;

    public int numberPie, numberPataDePerro, numberOjos, numberBrazo, numberDedo, numberMaiz, numberChile, numberChapulines, numberChinicuiles, numberLegumbres,
        numberFrijoles, numberGusanitos, numberHuitla;
    public string S_numberPie, S_numberPataDePerro, S_numberOjos, S_numberBrazo, S_numberDedo, S_numberMaiz, S_numberChile, S_numberChapulines, S_numberChinicuiles, S_numberLegumbres,
        S_numberFrijoles, S_numberGusanitos, S_numberHuitla;

    public AudioListener2 audioListener;

    void Start()
    {
        posPie = Pie.transform.position;
        posPataDePerro= pataDePerro.transform.position;
        posOjos = Ojos.transform.position;
        posBrazo= Brazo.transform.position;
        posDedo= Dedo.transform.position;
        posMaiz= Maiz.transform.position;
        posChile= Chile.transform.position;
        posChapulines= Chapulines.transform.position;
        posChinicuiles= Chinicuiles.transform.position;
        posLegumbres= Legumbres.transform.position;
        posFrijoles = Frijoles.transform.position;
        posGusanitos= Gusanitos.transform.position;
        posHuitlacoche = Huitlacoche.transform.position;

        S_numberPie = numberPie.ToString();
        S_numberPataDePerro = numberPataDePerro.ToString();
        S_numberOjos = numberOjos.ToString();
        S_numberBrazo = numberBrazo.ToString();
        S_numberDedo = numberDedo.ToString();
        S_numberMaiz = numberMaiz.ToString();
        S_numberChile = numberChile.ToString();
        S_numberChapulines = numberChapulines.ToString();
        S_numberChinicuiles = numberChinicuiles.ToString();
        S_numberLegumbres = numberLegumbres.ToString();
        S_numberFrijoles = numberFrijoles.ToString();
        S_numberGusanitos = numberGusanitos.ToString();
        S_numberHuitla = numberHuitla.ToString();

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Pie")
        {
           
            Destroy(coll.gameObject);
            Instantiate(Pie, posPie, Quaternion.identity);
            Pie.GetComponent<BoxCollider2D>().enabled = true;
            numberPie += 1;
            S_numberPie = numberPie.ToString();
            audioListener.PlayAudio();
            Debug.Log(numberPie);

        }
        if (coll.gameObject.tag == "pataDePerro")
        {
           
            Destroy(coll.gameObject);
            Instantiate(pataDePerro, posPataDePerro, Quaternion.identity);
            pataDePerro.GetComponent<CircleCollider2D>().enabled = true;
            numberPataDePerro+= 1;
            S_numberPataDePerro= numberPataDePerro.ToString();
            audioListener.PlayAudio();
            Debug.Log(numberPataDePerro);
        }
        if (coll.gameObject.tag == "Ojos")
        {

            Destroy(coll.gameObject);
            Instantiate(Ojos, posOjos, Quaternion.identity);
            Ojos.GetComponent<BoxCollider2D>().enabled = true;
            numberOjos += 1;
            S_numberOjos= numberOjos.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Brazo")
        {

            Destroy(coll.gameObject);
            Instantiate(Brazo, posBrazo, Quaternion.identity);
            Brazo.GetComponent<BoxCollider2D>().enabled = true;
            numberBrazo += 1;
            S_numberBrazo= numberBrazo.ToString();
            audioListener.PlayAudio();
        }
       
        if (coll.gameObject.tag == "Dedo")
        {

            Destroy(coll.gameObject);
            Instantiate(Dedo, posDedo, Quaternion.identity);
            Dedo.GetComponent<BoxCollider2D>().enabled = true;
            numberDedo += 1;
            S_numberDedo= numberDedo.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Maiz")
        {

            Destroy(coll.gameObject);
            Instantiate(Maiz, posMaiz, Quaternion.identity);
            Maiz.GetComponent<BoxCollider2D>().enabled = true;
            numberMaiz += 1;
            S_numberMaiz= numberMaiz.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Chile")
        {

            Destroy(coll.gameObject);
            Instantiate(Chile, posChile, Quaternion.identity);
            Chile.GetComponent<BoxCollider2D>().enabled = true;
            numberChile += 1;
            S_numberChile= numberChile.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Chapulines")
        {

            Destroy(coll.gameObject);
            Instantiate(Chapulines, posChapulines, Quaternion.identity);
            Chapulines.GetComponent<BoxCollider2D>().enabled = true;
            numberChapulines += 1;
            S_numberChapulines= numberChapulines.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Chinicuiles")
        {

            Destroy(coll.gameObject);
            Instantiate(Chinicuiles, posChinicuiles, Quaternion.identity);
            Chinicuiles.GetComponent<BoxCollider2D>().enabled = true;
            numberChinicuiles += 1; 
            S_numberChinicuiles= numberChinicuiles.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Legumbres")
        {

            Destroy(coll.gameObject);
            Instantiate(Legumbres, posLegumbres, Quaternion.identity);
            Legumbres.GetComponent<BoxCollider2D>().enabled = true;
            numberLegumbres+= 1;
            S_numberLegumbres= numberLegumbres.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Frijoles")
        {

            Destroy(coll.gameObject);
            Instantiate(Frijoles, posFrijoles, Quaternion.identity);
            Frijoles.GetComponent<BoxCollider2D>().enabled = true;
            numberFrijoles += 1;
            S_numberFrijoles= numberFrijoles.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Gusanitos")
        {

            Destroy(coll.gameObject);
            Instantiate(Gusanitos, posGusanitos, Quaternion.identity);
            Gusanitos.GetComponent<BoxCollider2D>().enabled = true;
            numberGusanitos += 1;
            S_numberGusanitos= numberGusanitos.ToString();
            audioListener.PlayAudio();
        }
        if (coll.gameObject.tag == "Huitlacoche")
        {

            Destroy(coll.gameObject);
            Instantiate(Huitlacoche, posHuitlacoche, Quaternion.identity);
            Huitlacoche.GetComponent<BoxCollider2D>().enabled = true;
            numberHuitla += 1;
            S_numberHuitla = numberHuitla.ToString();
            audioListener.PlayAudio();
        }
        

    }



 

    // Update is called once per frame
    void Update()
    {
        
    }
}
