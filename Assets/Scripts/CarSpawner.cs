using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _car;
    private void Awake()
    {
        Instantiate(_car);
    }
}
