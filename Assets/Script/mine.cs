using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mine : MonoBehaviour
{
    [SerializeField] private GameObject _mine; //мина
    [SerializeField] private Transform _mineSpawnPlase; //точка где будет спавнится мина

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(_mine, _mineSpawnPlase.position, _mineSpawnPlase.rotation);
        }
    }
}
