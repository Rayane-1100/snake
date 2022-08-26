using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoretxt;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {
            score++;
            PlayerPrefs.SetInt("Savedscore", score);
            Destroy(collision.gameObject);
            scoretxt.text = score.ToString();

            if (score > PlayerPrefs.GetInt("Highscore"))
            {
                PlayerPrefs.SetInt("Highscore", score);
            }
        }
        
    }
}
