using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _maxScale = 5f;

    [SerializeField] private float _minScale = 0.5f;

    [SerializeField] private float _growSpeed = 1;

    private float _time = 0f;

    private void Update()
    {
        _time += Time.deltaTime * _growSpeed;

        float currentGrow = _minScale + Mathf.PingPong(_time, _maxScale - _minScale);
        transform.localScale = new Vector3(currentGrow, currentGrow , currentGrow);
    }
}