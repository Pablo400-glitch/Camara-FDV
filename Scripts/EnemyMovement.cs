using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector2 direccionMovimiento;

    void Start()
    {
        // Comienza moviéndose a la derecha
        direccionMovimiento = Vector2.right;
    }

    void Update()
    {
        // Mover el objeto en la dirección establecida
        transform.Translate(direccionMovimiento * velocidad * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Cambia la dirección de movimiento al rebotar
        direccionMovimiento = -direccionMovimiento; // Invertir la dirección al chocar
    }
}
