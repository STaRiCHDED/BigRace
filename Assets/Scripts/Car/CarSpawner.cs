using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _car;
    
    [SerializeField]
    private Transform _parent;
    void Awake()
    {
        Instantiate(_car, _parent);
    }
}