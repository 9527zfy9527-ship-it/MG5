using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed;
    [SerializeField] private float _runTime;

    private float _time;
    private Vector3 _direction;

    // ------------------------------------------------------------------------
    private void Update()
    {
        if (_time > 0.0f)
        {
            _time -= Time.deltaTime;

            if (_time <= 0.0f)
            {
                _animator.SetBool("isMoving", false);
            }
        }
    }

    // ------------------------------------------------------------------------
    public void RunAway(Vector3 playerPosition)
    {
        _time = _runTime;
        _animator.SetBool("isMoving", true);

        _direction = (transform.position - playerPosition).normalized;
        _rb.linearVelocity = _direction * _speed;
        transform.forward = _direction;
    }
}