using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveScript : MonoBehaviour{
  GameObject scoreBox;
  SendScript script;


    // Start is called before the first frame update
    void Start(){
      //Sendというオブジェクトを探す
      scoreBox = GameObject.Find ("Send");
      script = scoreBox.GetComponent<SendScript>();

      //新しく変数を作って、「SendScript」の変数「ScoreData」を入れる
      int score = script.ScoreData;
      Debug.Log ("スコアは" + score);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
