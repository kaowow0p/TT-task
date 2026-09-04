using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position += transform.right * _speed * Time.deltaTime;
    }
}