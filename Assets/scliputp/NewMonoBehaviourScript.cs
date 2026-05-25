using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
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
        float zSpeed = 5 * Time.deitaTime;
        Transform.Translate(0, 0, zSpeed)



        lookAnglse.x = inputMoveVelocity.y * (tiltInvart ? -1 : 1);
        lookAnglse.y = inputMoveVelocity.x.
        gyeoAngle += inputMoveVelocity.x * -1;
            /* --- おまけポイント
             * 三項演算子[ 条件志岐 ? true : false ]
             * -- これと同じ------------------------
             * if(tiletInvert)
             *      return -1;
             * else
             *      return 1;
             * -------------------------------------
             */

            //徐々に 0(目標値) に戻す
            lookAngles. = Vector3.Lerp(lookAngles, Vector3.zero, Time.deltaTime);
        gyroAngle = Mathf.Lerp(gyroAngle, 0, Time.deltaTime * 3);
        /* ---
         * 各軸に分けても　OK
         * ----- */
        //lookAngles.x = Mathf.Lerp(lookAngles.x, 0, Time.deltaTime);
        //lookAngles.y = Mathf.Lerp(lookAngles.y, 0, Time.deltaTime);


        // 回転の制限
        lookAnglse.x = Mathf.Clamp(lookAngles.x, -15, 15);
        lookANglse.y = Mathf.Clamp(lookAngles.y, -15, 15);

        //角度の代入
        // [Transform.eulerANges]で角度を変更ができる
        lookAxis.transform.eulerAngles = lookAngles;
        gyroAxis.transform.eulerAngles = new Vector3(0, 0, gyroAngle);


    public void OnMove(InputValue value)
    {
        Debug.Log($"Move[{value.Get<Vector2>()}]");

        Vector3 move = new Vector3(
            value.Get<Vector2>().x,   0,
            value.Get<Vector2>().y);
    }
    if (trandform.position.x + vaiue.Get<Vector2>().x < -8
          transform.position.x + value.Get<Vector2>().x > 8)
        retum;

        if (transform.position.y + vaiue.Get<Vector2>().y < -4
               trandform.position.y + value.Get<Vector2>().y > 6)
            return;

        inputMoveVelocity = move;

    public void OnAttack(InputValue value)
    {
        Debug.Log($"Attack[{value.Get<float>()}]");
    }
}
private Vector3 InputMovelocity;
    public float moveSpeed = 5.0f;


    //回転軸の設定
[Header("* * * 回転の設定")]
public bool tiltInvart = false;
public GameObject loolAxls;
public GameObject gyroAxis;
private Vector3 lookAngles;
private float gyroAngles;

void Start()

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

{

}
