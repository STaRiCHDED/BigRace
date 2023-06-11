using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private const int STANDART_ROTATION = 45;

    [SerializeField] private float _speed;

    [SerializeField] private float _rotateSpeed = 0.5f;

    private Vector3 _currentDirection;
    private int _forwardSide;
    private int _currentRotation;

    private void Awake()
    {
        _forwardSide = (int) transform.eulerAngles.y;
        _currentRotation = _forwardSide;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _currentDirection.x = -_speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _currentDirection.x = _speed * Time.deltaTime;
        }
        else
        {
            _currentDirection.x = 0;
        }

        if (Input.GetKey(KeyCode.D) && _currentRotation < _forwardSide + STANDART_ROTATION)
        {
            transform.Rotate(0, _rotateSpeed, 0);
            _currentDirection.z = _speed * _rotateSpeed * Time.deltaTime;
            _currentRotation++;
        }
        else if (Input.GetKey(KeyCode.A) && _currentRotation > _forwardSide - STANDART_ROTATION)
        {
            transform.Rotate(0, -_rotateSpeed, 0);
            _currentDirection.z = -_speed * _rotateSpeed * Time.deltaTime;
            _currentRotation--;
        }
        else if (_currentRotation != _forwardSide)
        {
            if (_currentRotation < _forwardSide)
            {
                transform.Rotate(0, _rotateSpeed, 0);
                _currentRotation++;
            }
            else
            {
                transform.Rotate(0, -_rotateSpeed, 0);
                _currentRotation--;
            }
            _currentDirection.z = 0;
        }
        transform.position += _currentDirection;
    }
}