using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;


public class lecturaWeb : MonoBehaviour
{

    float tiempo = 2f;
    //Vector3 tamanio; 
    //float escala = 5f; 
    //public Text elCampo;
    //public GameObject laBarra;
    public GameObject[] models;

    void Start()
    {

        models[0].SetActive(false);
        models[1].SetActive(false);
        models[2].SetActive(false);

        StartCoroutine(ObtenerDatos(tiempo));
    }


    IEnumerator ObtenerDatos(float tiempo)
    {
        while (true)
        {
            //UnityWebRequest datosWeb = UnityWebRequest.Get("https://csrng.net/csrng/csrng.php?min=0&max=100&fbclid=IwAR0j7RSD6NwUxZ84dNbEQkaX_tN2dH9_4qRZLQTA8kvE9yWU-YSQv-3gGQA");
            //yield return datosWeb.Send();

            //if (datosWeb.isNetworkError)
            //{
            //    Debug.Log(datosWeb.error);
            //}
            //else
            //{

            //    //Debug.Log(datosWeb.downloadHandler.text);
            //    string elDato = datosWeb.downloadHandler.text;


            //    //escala = float.Parse(elDato);
            //    //tamanio = transform.localScale; 
            //    //tamanio.y = (escala / 100) / 3;
            //    //laBarra.transform.localScale = tamanio;
            //    //elCampo.text = elDato + " %";


            //    //aqui segunesta el error we

            //    //we no se porque no me sirve el autocomplete de las palabras resevadas
            //    if (Int32.Parse(elDato) == 0 && Int32.Parse(elDato) >= 30)
            //    {
            //        models[0].SetActive(true); 
            //        models[1].SetActive(false);
            //        models[2].SetActive(false);
            //    } else if (Int32.Parse(elDato) > 30 && Int32.Parse(elDato) <= 60)
            //    {
            //        models[0].SetActive(false);
            //        models[1].SetActive(true);
            //        models[2].SetActive(false);
            //    }
            //    else if (Int32.Parse(elDato) > 60 && Int32.Parse(elDato) <= 100)
            //    {
            //        models[0].SetActive(false);
            //        models[1].SetActive(false);
            //        models[2].SetActive(true);
            //    }


            //}

            int modelRandom = UnityEngine.Random.Range(1, 100);


            Debug.Log("[{status: success, min: 0,max: 100, rabdom: " + modelRandom + "}]");

            if (modelRandom > 0 && modelRandom <= 30)
            {
                models[0].SetActive(true);
                models[1].SetActive(false);
                models[2].SetActive(false);
            }
            else if (modelRandom > 30 && modelRandom <= 60)
            {
                models[0].SetActive(false);
                models[1].SetActive(true);
                models[2].SetActive(false);
            }
            else if (modelRandom > 60 && modelRandom <= 100)
            {
                models[0].SetActive(false);
                models[1].SetActive(false);
                models[2].SetActive(true);
            }





            yield return new WaitForSeconds(tiempo);
        }
    }

    void Update()
    {

    }

}
