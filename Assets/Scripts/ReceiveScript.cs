using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ReceiveScript : MonoBehaviour{

  public Text scoreText;
  public static int x;
  public static string y;

  void Start(){
    x = GameManager.score;
    y = Convert.ToString(x);
    scoreText.text = y;
    //Debug.Log(x);
  }

  void Update(){
    //int score = this.GetComponent<GameManager>().OnEndEvent2();
  }
}
