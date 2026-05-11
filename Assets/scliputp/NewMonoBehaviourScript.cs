using System;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {

    }

    public void OnMove(InputValue value)
    {
        Debug.Log($"Move[{value.Get<Vector2>()}]");

        Vector3 move = new Vector3(value.Get<Vector2>().x,
            0,
            value.Get<Vector2>().y);
    }
    if (trandform.position.x + vaiue.Get<Vector2>().x < -8
          transform.position.x + value.Get<Vector2>().x > 8)
        retum;

        if (transform.position.y + vaiue.Get<Vector2>().y < -4
               trandform.position.y + value.Get<Vector2>().y > 6)
            return;
    public void OnAttack(InputValue value)
    {
        Debug.Log($"Attack[{value.Get<float>()}]");
    }
}
public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public lifeTime = 2f;

        void Start()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
public class Gun : MonoBehavipur
{
    public GameObject bulletPrefab;
    public Transform muzzle;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, muzzle.position)
        }
    }

    private void Instantiate(GameObject bulletPrefab, Vector3 position)
    {
        throw new NotImplementedException();
    }
}