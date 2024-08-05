using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    [SerializeField]
    IAbility currentAbility =
        new SequenceComposite
         (
            new IAbility[]
            {
                new HealAbility(),
                new RageAbility(),
                new DelayedDecorator
                (
                   new RageAbility()
                )
            }
        );



    private void Start()
    {
        UseAbility();
    }


    public void UseAbility()
    {
        currentAbility.Use(gameObject);
    }
}
