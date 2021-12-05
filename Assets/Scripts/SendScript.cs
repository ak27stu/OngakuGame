using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScript : MonoBehaviour{
  GameManager gm = new GameManager();

  public int ScoreData = gm.ReturnScore();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
