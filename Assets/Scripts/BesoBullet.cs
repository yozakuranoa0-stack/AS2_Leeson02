using UnityEngine;
using UnityEngine.UIElements;

public class BesoBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // === 非公開変数 === 
        
    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
    }

    public void Reset()
    {
        // 1フレーム当たりの飛距離
        Vector3 posA = transform.position + _rigid

        // 線(Ray)を作る
        // * (起点座標.　線の方向)
        Ray ray = Ray(transform, position, transform, forward);
        // デバック用の線を線画
        Debug.DrawRay(transform, position, transform, forward, Color.red);

        //RayとRaycastHitを組み合わせる
        //Physics.Raycast(線, out 衝突したオブジェクト情報, 衝突距離)；
        //　戻り値：衝突フラグ
        RaycastHit hit;
        Physics.Raycast(ray out new RaycastHit(), 100, 1 >> 0);
        //Debug.Log($"layer => {}")
        if(Collision == true)
        {
            Debug.Log($"線状にオブジェクトがあります => {hit.transform?.name}");
            if( hit.transform.name.Contains("Enemy"))
            {
                Debug.Log("敵のオブジェクトに衝突しました。");
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
