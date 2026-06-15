using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ルート要素（親）の取得
        _root = uid.rootVisualElement;

        // スコアテキストの取得
        _scoreText = _root.Q<Label>("score-label");
        // スコアテキストの更新
        _scoreText.text = "ココにスコアの文字列を表示する。"

        // === ゲーム終了ボタンの取得 === //
        _gameQuitButton = _root.Q<Button>("game-quit-button");
        // ボタンの押下イベントの設定
        _gamQuitButton.clicked += () => {
            Debug.Log("ゲーム終了");

            UNITY＿EDITOR
            // エディタの再生を止める　（エディタ用）
            Edit
            };
    }

    // Update is called once pe r frame
    void Update()
    {
        
    }
}
