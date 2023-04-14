using UnityEngine;

public class CarController : MonoBehaviour
{
    private const float RIGHR_BORDER = 1;
    private const float LEFT_BORDER = -1;
    private const float BACK_BORDER = -14;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _rotation;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            MoveForvard();
        if (Input.GetKey(KeyCode.S))
            MoveBack();
        if (Input.GetKey(KeyCode.D))
            TurnRight();
        if (Input.GetKey(KeyCode.A))
            TurnLeft();

        var currentX = transform.position.x;
        var currentY = transform.position.y;
        var currentZ = transform.position.z;

        if (transform.position.z <= BACK_BORDER)
            transform.position = new Vector3(currentX, currentY, BACK_BORDER + 0.005f);

        if (transform.position.x >= RIGHR_BORDER)
            transform.position = new Vector3(RIGHR_BORDER - 0.005f, currentY, currentZ);

        if (transform.position.x <= LEFT_BORDER)
            transform.position = new Vector3(LEFT_BORDER + 0.005f, currentY, currentZ);
    }
    private void MoveForvard()
    {
        if (transform.position.x <= RIGHR_BORDER
            && transform.position.x >= LEFT_BORDER
            && transform.position.z >= BACK_BORDER)
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
    private void MoveBack()
    {
        if (transform.position.x <= RIGHR_BORDER
           && transform.position.x >= LEFT_BORDER
           && transform.position.z >= BACK_BORDER)
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime * -1);
        }
    }
    private void TurnRight() => transform.Rotate(Vector3.up * _rotation * Time.deltaTime);
    private void TurnLeft() => transform.Rotate(Vector3.up * _rotation * Time.deltaTime * -1);
}
