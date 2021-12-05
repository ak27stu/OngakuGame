using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject score_object; // Textオブジェクト
    public int score_num = 0; // スコア変数
    public GameManager gm;

      // 初期化
      void Start () {
        score_object = GameObject.Find("GameManager");
        gm = score_object.GetComponent<GameManager>();
      }

      // 更新
      void Update () {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score:" + gm.ReturnScore();



        score_num += 1; // とりあえず1加算し続けてみる

        if(score_num==100){
          return;
        }
        

      }
}
