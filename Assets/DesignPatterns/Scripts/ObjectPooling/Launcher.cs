using System;
using UnityEngine;
using UnityEngine.Pool;

public class Launcher : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;

    private IObjectPool<Bullet> bulletPool;



    private void Awake()
    {
        bulletPool = new ObjectPool<Bullet>
            (
            CreateBullet,
            OnGet,
            OnReleased,
            OnDestroyed,
            maxSize:3
            );
    }


    private Bullet CreateBullet()
    {
        Bullet bullet = Instantiate(bulletPrefab);

        bullet.SetPool(bulletPool);

        return bullet;
    }


    private void OnGet(Bullet bullet)
    {
        bullet.gameObject.SetActive(true);

        bullet.transform.position = transform.position;
    }


    private void OnReleased(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
    }


    private void OnDestroyed(Bullet bullet)
    {
        Destroy(bullet.gameObject);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletPool.Get();
        }
    }
}
