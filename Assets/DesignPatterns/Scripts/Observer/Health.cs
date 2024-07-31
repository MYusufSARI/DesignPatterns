using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float fullHealth = 100f;
    [SerializeField] float drainPerSecond = 2f;

    [SerializeField] private ParticleSystem _particleSystem;

    float currentHealth = 0;


    private void Awake()
    {
        ResetHealth();

        StartCoroutine(HealthDrain());
    }


    private void Start()
    {
        Level.onLevelUp += ResetHealth;
    }


    private void OnDestroy()
    {
        Level.onLevelUp -= ResetHealth;
    }


    public float GetHealth()
    {
        return currentHealth;
    }


    private void ResetHealth()
    {
        currentHealth = fullHealth;

        _particleSystem.Play();
    }


    private IEnumerator HealthDrain()
    {
        while(currentHealth > 0)
        {
            currentHealth -= drainPerSecond;

            yield return new WaitForSeconds(1);
        }
    }
}
