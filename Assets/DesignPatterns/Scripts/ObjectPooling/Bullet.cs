using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 _speed;

    private IObjectPool<Bullet> bulletPool;

    public void SetPool(IObjectPool<Bullet> pool)
    {
        bulletPool = pool;
    }


    private void Update()
    {
        transform.position += _speed * Time.deltaTime;
    }


    private void OnBecameInvisible()
    {
        bulletPool.Release(this);
    }
}
