using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, mejorPuntuacion;
    [SerializeField] float tiempo;
<<<<<<< Updated upstream
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] GameObject texto, boton;
    [SerializeField] GameObject jugador, enemigo;
    [SerializeField] bool actdescronometro;

    public static GameManager Instance { get; internal set; }

=======
    [SerializeField] GameManager gameOver, botonRestart;
    [SerializeField] GameManager personaje, enemigo;
    [SerializeField] bool actdescronometro;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
<<<<<<< Updated upstream

=======
        gameOver.SetActive(false);
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        Debug.Log(minutos + ":" + segundos);
        textoTiempo.text = minutos + ":" + segundos;
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
