using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    int score = 0;
    int eggsTotal = 0;
    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Chickens Slaughtered: " + score.ToString() + "\n Eggs Collected: " + eggsTotal.ToString();
    }

    public void AddPoint(){
        score += 1;
        if (score == 4 & eggsTotal == 4){
            scoreText.text = "All Done!\nThanks for your help on the farm!";
        }
        else{
            scoreText.text = "Chickens Slaughtered: " + score.ToString() + "\n Eggs Collected: " + eggsTotal.ToString();
        }
    }

    public void AddEgg(){
        eggsTotal += 1;
        if (score == 4 & eggsTotal == 4){
            scoreText.text = "All Done!\nThanks for your help on the farm!";
        }
        else{
            scoreText.text = "Chickens Slaughtered: " + score.ToString() + "\n Eggs Collected: " + eggsTotal.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
