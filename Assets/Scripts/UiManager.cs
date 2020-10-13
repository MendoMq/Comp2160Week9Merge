using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    public ScoreKeeper keeper;
    public Text scoreText;
    private string scoreFormat = "Score: {0}";
    // Start is called before the first frame update
    void Start()
    {
        keeper = GameObject.Find("ScoreKeeper").GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text= string.Format(scoreFormat,keeper.Score);
    }
}
