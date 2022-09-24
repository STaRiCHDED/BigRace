using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private float _rotateSpeed = 0.5f;

    private Vector3 _direction;

    private Quaternion _standartRotation;

    private void Awake()
    {
        _standartRotation = transform.rotation;
    }

    void Update()
    {
        var position = transform.position;
        var rotation = transform.rotation;

        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log($"{rotation.y * 57.3} = {rotation.y}");
            _direction.x = -speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _direction.x = speed * Time.deltaTime;
        }
        else
        {
            _direction.x = 0;
        }
        
        if (Input.GetKey(KeyCode.D) &&  rotation.y < -0.44)
        {
            Debug.Log(rotation.y * 57.3);
            rotation.y += _rotateSpeed * Time.deltaTime;
            _direction.z = speed * _rotateSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A) &&  rotation.y > - 0.9)
        {
            Debug.Log(rotation.y * 57.3);
            rotation.y -= _rotateSpeed * Time.deltaTime;
            _direction.z = -speed * _rotateSpeed * Time.deltaTime;
        }
        else if (rotation.y != _standartRotation.y)
        {
            if (rotation.y < _standartRotation.y)
                rotation.y += _rotateSpeed * Time.deltaTime;
            else
                rotation.y -= _rotateSpeed * Time.deltaTime;
            _direction.z = 0;
        }
        transform.position += _direction;
        transform.rotation = rotation;
    }
}