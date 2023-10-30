using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyRandom : MonoBehaviour
{
    public float circleRadius = 5f;
    public float verticalRange = 2f;
    public float rotationSpeed = 2f;

    private float verticalOffset;
    private float elapsedTime;

    void Start()
    {
        // Inicializa una posici�n vertical aleatoria para la mariposa
        verticalOffset = Random.Range(-verticalRange, verticalRange);
    }

    void Update()
    {
        // Incrementa el tiempo transcurrido
        elapsedTime += Time.deltaTime;

        // Calcula la posici�n local en el c�rculo
        float xPos = Mathf.Cos(elapsedTime * rotationSpeed) * circleRadius;
        float zPos = Mathf.Sin(elapsedTime * rotationSpeed) * circleRadius;

        // Combina la posici�n local del c�rculo con la posici�n vertical aleatoria
        Vector3 localPosition = new Vector3(xPos, verticalOffset, zPos);

        // Actualiza la posici�n local del objeto
        transform.localPosition = localPosition;

        // Calcula la rotaci�n para que mire hacia el centro del c�rculo en la posici�n local
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.zero - localPosition, Vector3.up);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

}
