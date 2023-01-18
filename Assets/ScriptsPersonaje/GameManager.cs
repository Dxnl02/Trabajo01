using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, mejorPuntuacion;

    [SerializeField] float tiempo;

    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] GameObject texto, boton;
    [SerializeField] GameObject jugador, enemigo;
    [SerializeField] bool actdescronometro;



    public static GameManager Instance { get; internal set; }


    [SerializeField] GameManager gameOver, botonRestart;
    [SerializeField] GameManager personaje, enemigo;
    [SerializeField] bool actdescronometro;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {



        gameOver.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Perder()
    {
            jugador.SetActive(false);
            enemigo.SetActive(false);
            boton.SetActive(true);
            texto.SetActive(true);
            actdescronometro = false;
    }

    public void ReiniciarJuego()
    {
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        tiempo = 0;
        actdescronometro = true;
        enemigo.GetComponent<Enemigo>().IniciarEnemigo();
    }

    public void ActualizarPuntuacion()
    {
        puntuacionActual += 1;
        if (puntuacionActual > mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", mejorPuntuacion);
        }
    }
}
