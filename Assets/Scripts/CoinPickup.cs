using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    //public ScoreKeeper keeper;
    // Start is called before the first frame update
    void Start()
    {
        //keeper = GameObject.Find("ScoreKeeper").GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other){
        //keeper.CoinPickup();
        Destroy(gameObject);
    }
}
