using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mine : MonoBehaviour
{
    [SerializeField] private GameObject _mine; //����
    [SerializeField] private Transform _mineSpawnPlase; //����� ��� ����� ��������� ����

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(_mine, _mineSpawnPlase.position, _mineSpawnPlase.rotation);
        }
    }
}
