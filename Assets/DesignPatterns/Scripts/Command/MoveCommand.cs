using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform _transform;
    private Vector3 _direction;
    private float _distance;

    // Constructor
    public MoveCommand(Transform transform, Vector3 direction, float distance)
    {
        _transform = transform;
        _direction = direction;
        _distance = distance;
    }

    // Execute the move command
    public void Execute()
    {
        _transform.position += _direction * _distance;
    }

    // Undo the move command
    public void Undo()
    {
        _transform.position -= _direction * _distance;
    }
}

