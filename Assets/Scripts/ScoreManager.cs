using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject score_object1 = null; // Textオブジェクト
    public GameObject score_object2 = null; // Textオブジェクト
    public GameObject score_object3 = null; // Textオブジェクト
    public GameObject score_object4 = null; // Textオブジェクト
    public int score_num = 0; // スコア変数

      // 初期化
      void Start () {
      }

      // 更新
      void Update () {
        // オブジェクトからTextコンポーネントを取得
        Text score_text1 = score_object1.GetComponent<Text> ();
        // テキストの表示を入れ替える
        score_text1.text = "Score:" + Judgement.Update();

        /*
        if(Judgement.distance<3){

        }

        Text score_text2 = score_object2.GetComponent<Text> ();
        // テキストの表示を入れ替える
        score_text2.text = "Score:" + Judgement.AddScore();

        Text score_text3 = score_object3.GetComponent<Text> ();
        // テキストの表示を入れ替える
        score_text3.text = "Score:" + Judgement.AddScore();

        Text score_text4 = score_object4.GetComponent<Text> ();
        // テキストの表示を入れ替える
        score_text4.text = "Score:" + Judgement.AddScore();

        score_num += 1; // とりあえず1加算し続けてみる

        if(score_num==100){
          return;
        }
        */

      }
}
