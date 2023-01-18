using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IgualarTextos : MonoBehaviour
{
    [SerializeField] TMP_Text textoPuntuacionActual;
    [SerializeField] TMP_Text textomejorPuntuacion;
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] float tiempo;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        Debug.Log(minutos + ":" + segundos);
        textoTiempo.text = minutos + ":" + segundos;

        textoPuntuacionActual.text = GameManager.Instance.puntuacionActual.ToString();
        textomejorPuntuacion.text = GameManager.Instance.mejorPuntuacion.ToString();
    }
}
