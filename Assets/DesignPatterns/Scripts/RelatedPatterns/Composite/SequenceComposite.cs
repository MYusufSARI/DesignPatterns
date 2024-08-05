using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceComposite : IAbility
{
    private IAbility[] children;


    public SequenceComposite(IAbility[] children)
    {
        this.children = children;
    }

    public void Use(GameObject currentGameObject)
    {
        foreach (var child in children)
        {
            child.Use(currentGameObject);
        }
    }
}
