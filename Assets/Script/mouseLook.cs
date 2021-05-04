using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    float xRotation;
    float yRotation;
    float xRotCurent;
    float yRotCurent;
    float currentVelosityX;
    float currentVelosityY;
    [SerializeField] float smoothTime = 0.1f;
    [SerializeField] Camera player;
    [SerializeField] float sensivity = 5f;
    [SerializeField] GameObject playerGameObject;


    private void Update()
    {
        MouseMove();
    }

    void MouseMove()
    {
        xRotation += Input.GetAxis("Mouse X") * sensivity;
        yRotation += Input.GetAxis("Mouse Y") * sensivity;
        yRotation = Mathf.Clamp(yRotation, -90, 90); //ограничение камеры

        xRotCurent = Mathf.SmoothDamp(xRotCurent, xRotation, ref currentVelosityX, smoothTime);
        yRotCurent = Mathf.SmoothDamp(yRotCurent, yRotation, ref currentVelosityY, smoothTime);

        player.transform.rotation = Quaternion.Euler(-yRotCurent, xRotCurent, 0f);
        playerGameObject.transform.rotation = Quaternion.Euler(0f, xRotCurent, 0f);
    }


}
