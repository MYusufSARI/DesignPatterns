using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CommandManager : MonoBehaviour
{
    public Transform objectToMove;
    private CommandInvoker _commandInvoker;

    void Start()
    {
        _commandInvoker = new CommandInvoker();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ICommand moveUp = new MoveCommand(objectToMove, Vector3.up, 1f);
            _commandInvoker.ExecuteCommand(moveUp);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ICommand moveDown = new MoveCommand(objectToMove, Vector3.down, 1f);
            _commandInvoker.ExecuteCommand(moveDown);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            _commandInvoker.UndoLastCommand();
        }
    }
}

