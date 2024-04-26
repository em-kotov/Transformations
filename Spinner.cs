using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(transform.up * _speed * Time.deltaTime);
    }
}
