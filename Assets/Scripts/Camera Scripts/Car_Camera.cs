using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Camera : MonoBehaviour
{
    private Car car;
    
    [SerializeField]
    private Vector3 offset;
    void Start()
    {
        car = FindObjectOfType<Car>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = car.transform.position + offset;
    }
}
