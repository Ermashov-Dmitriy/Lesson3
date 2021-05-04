using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternion : MonoBehaviour
{
    [SerializeField]
    private Transform _Quaternion; 



    private void OnTriggerEnter(Collider other)
    {
        var relativePosition = _Quaternion.position - transform.position;
        var rotation = Quaternion.LookRotation(relativePosition);
        transform.rotation = rotation;
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {

    }
}
