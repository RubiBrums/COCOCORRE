using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform helen;

    private float cameraSize;
    private float anchoPantalla;

    void Start()
    {
        cameraSize = Camera.main.orthographicSize;
        anchoPantalla = cameraSize * 2;
    }
    void Update()
    {
        CalcularPosicion();
    }
    void CalcularPosicion()
    {
        int pantallaPersonaje = (int)(helen.position.x / anchoPantalla);
        float anchoCamara = (pantallaPersonaje * anchoPantalla) + cameraSize;

        transform.position = new Vector3(anchoCamara, transform.position.y, transform.position.z);
    }
}
