using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    private Stack<ICommand> _commandHistory = new Stack<ICommand>();

    // Execute a command and store it in the history
    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    // Undo the last executed command
    public void UndoLastCommand()
    {
        if (_commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
    }
}

