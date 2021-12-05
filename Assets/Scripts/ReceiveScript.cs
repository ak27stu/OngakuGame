using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveScript : MonoBehaviour{
  GameObject go;
  GameManager gm;

    // Start is called before the first frame update
    void Start(){
      //Scoreというオブジェクトを探す
      //これ　go = GameObject.Find("Score");

    }

    // Update is called once per frame
    void Update(){
      //これ　go.GetComponent<GameManager>().ReturnScore();

      //新しく変数を作って、「SendScript」の変数「ScoreData」を入れる
      //int score = gm.score;
      //Debug.Log ("スコアは" + score);

      Debug.Log(GetComponent<GameManager>().ReturnScore());
    }
}
