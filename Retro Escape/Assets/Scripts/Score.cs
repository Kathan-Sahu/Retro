using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text myScoreText;
    private int scoreNum;
    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        myScoreText.text = "Score : " + scoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.tag == "Mycoin")
        {
            scoreNum++;
            Destroy(coin.gameObject);
            myScoreText.text = "Score : " + scoreNum;
        }   
    }
}
