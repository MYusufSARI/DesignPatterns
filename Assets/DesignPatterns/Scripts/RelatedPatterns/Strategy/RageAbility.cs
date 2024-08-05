using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RageAbility : IAbility
{
    public void Use(GameObject currentGameObject)
    {
        Debug.Log(" I'm always angry! ");
    }
}
