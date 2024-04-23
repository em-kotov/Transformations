using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale += new Vector3(1, 1, 1) * _speed * Time.deltaTime;
    }
}
