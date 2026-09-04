using UnityEngine;

public class RotateByY : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(new Vector3(0,Time.deltaTime * _speed ,0));
    }
}
