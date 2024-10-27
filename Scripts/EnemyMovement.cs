using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector2 direccionMovimiento;

    void Start()
    {
        // Comienza movi�ndose a la derecha
        direccionMovimiento = Vector2.right;
    }

    void Update()
    {
        // Mover el objeto en la direcci�n establecida
        transform.Translate(direccionMovimiento * velocidad * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Cambia la direcci�n de movimiento al rebotar
        direccionMovimiento = -direccionMovimiento; // Invertir la direcci�n al chocar
    }
}
