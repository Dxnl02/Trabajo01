using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] UnityEngine.Camera camara;
    [SerializeField] Vector3 posicionMinima, posicionInicial;
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        camara = UnityEngine.Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = camara.ViewportToWorldPoint(new Vector2(1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * velocidad);
    }
}
