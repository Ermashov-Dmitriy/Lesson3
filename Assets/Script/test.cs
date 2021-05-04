using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField]
    private Transform _waypoints;



    [SerializeField]
    private float _speed = 5;
    

    private float _distance;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _waypoints.position, _speed * Time.deltaTime);
    }
}
