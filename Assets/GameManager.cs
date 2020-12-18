using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static int balls = 5;
    int cLevel = -1;
    public static GameManager main;
    public UnityEngine.UI.Text scoreField;
    public UnityEngine.UI.Text ballsField;
    int[] goals = new int[]{4,7,7,7,7};
    int[] levelBalls = new int[]{5,5,5,5,5,5};
    public GameObject[] levels;
    public GameObject levelComplete;
    public GameObject levelFailed;

    // Start is called before the first frame update
    void Start()
    {
        main = this;
        nextLevel();
    }
    public bool canShoot()
    {
        if(balls==0)return false;
        balls--;
        ballsField.text = "Balls : " + balls;
        if(balls==0)
        {
            Invoke("checkFail", 4f);
        }
        return true;
    }
    void checkFail()
    {
        if(balls==0 && score<goals[cLevel])
        {
            Debug.Log("failed");
            levelFailed.SetActive(true);
            cLevel--;
            Invoke("nextLevel", 2f);
        }
    }
    public void addScore(int amount)
    {
        score+=amount;
        scoreField.text = "Score : " + score;
        Debug.Log("score = " + score);
        if(score>=goals[cLevel])
        {
            balls = 0;
            levelComplete.SetActive(true);
            Invoke("nextLevel", 2f);
            
        }
    }

    void nextLevel()
    {
        levelComplete.SetActive(false);
        levelFailed.SetActive(false);
        TargetScript.resetTargets();

        cLevel++;
        if(cLevel==5)cLevel = 0;
        if(cLevel!=0)levels[cLevel-1].SetActive(false);
        levels[cLevel].SetActive(true);
        score = 0;
        balls = levelBalls[cLevel]*2;
        addScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
