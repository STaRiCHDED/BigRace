using UnityEngine;

public class Car_Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject car;
    
    [SerializeField]
    private Transform parent;
    void Awake()
    {
        Instantiate(car, parent);
    }
}