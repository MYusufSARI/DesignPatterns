using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDecorator : IAbility
{
    private IAbility wrappedAbility;


    public DelayedDecorator(IAbility wrappedAbility)
    {
        this.wrappedAbility = wrappedAbility;
    }


    public void Use(GameObject currentGameObject)
    {
        // TODO some delaying functionality
        wrappedAbility.Use(currentGameObject);
    }
}
