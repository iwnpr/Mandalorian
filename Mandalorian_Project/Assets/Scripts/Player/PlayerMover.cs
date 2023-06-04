using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;
    private Animator _animator;
    private float _animationTrigger = 0;


    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
        }
    }

    public void TryMoveUp()
    {
        if (_targetPosition.y < _maxHeight)
        {
            _animationTrigger += 1;
            _animator.SetFloat("Trigger", _animationTrigger);
            _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + _stepSize);
        }
    }

    public void TryMoveDown()
    {
        if (_targetPosition.y > _minHeight)
        {
            _animationTrigger -= 1;
            _animator.SetFloat("Trigger", _animationTrigger);
            _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y - _stepSize);
        }
    }

}
