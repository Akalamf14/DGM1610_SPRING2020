using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    public static int score;
    public int winScore;
    // static means we cannot alter the variable, we cant create an instance of this variable

    public Text winText;
    // Green means its a type, light blue means its a variable

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
       }

       scoreText.text =  " " + score;

       if(score >= winScore)
       {
           print("Win Score Reached = " + score);
           winText.GetComponent<Text>().enabled = true;
           Time.timeScale = 0;
       }

       if(Input.GetKeyDown(KeyCode.Escape))
       {
           SceneManager.LoadScene(0);
       }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        
    }
    
}
