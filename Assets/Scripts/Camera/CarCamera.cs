using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamera : MonoBehaviour
{
    private Car _car;
    
    [SerializeField]
    private Vector3 offset;
    void Start()
    {
        _car = FindObjectOfType<Car>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _car.transform.position + offset;
    }
}
