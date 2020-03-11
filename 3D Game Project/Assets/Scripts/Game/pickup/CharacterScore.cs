using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterScore : MonoBehaviour
{
    public static int score;
    public int winScore;

    public Text winText;

    private Text scoreText;
    
    void Awake()
    {
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();

        score = 0;

        winText.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(score < 0)
        {
            score = 0;
            scoreText.text = " " + score;

            if(score >= winScore)
            {
                print("Win Score Reached = " + score);
                winText.GetComponent<Text>().enabled = true;
                Time.timeScale = 0;
            }
        }
        
    }

    public static void AddPoints(int PointsToAdd)
    {
        score += PointsToAdd;
    }
}
