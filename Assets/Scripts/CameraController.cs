using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Vector3 _cameraOffset;

    private GameObject _car;

    private void Start()
    {
        _car = GameObject.FindGameObjectWithTag("Player");
    }
    private void LateUpdate()
    {
        transform.position = _car.transform.position + _cameraOffset;
    }
}
