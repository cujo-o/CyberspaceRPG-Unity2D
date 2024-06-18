using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class suikaManager : MonoBehaviour
{
    public static suikaManager instance;

    public suikaplayFabScript suikaplayFabScript;
      public bool LeaderboardSent;

    public int currentScore { get; set; }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private float fadetime = 2f;
  //  [SerializeField] private Image gameover;

    public float timeTillgameOver = 1.5f;
    public GameObject gameOVERpanel;



    // Start is called before the first frame update
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }

        scoreText.text = currentScore.ToString("0");
    }

    // Update is called once per frame
   public void Increasescore(int Amount)
    {
        currentScore += Amount;
        scoreText.text = currentScore.ToString("0");

    }

    void Update()
    {
        if (LeaderboardSent==false)
        {
            suikaplayFabScript.SendLeaderboard(currentScore);
            LeaderboardSent = true;
        }
    }

    public void GameOver()
    {
        // StartCoroutine(ResetGame());
       
      
        gameOVERpanel.SetActive(true);
        Time.timeScale = 0;

    }

   // private IEnumerator ResetGame()
   // {

  //  }
  public void startAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOVERpanel.SetActive(false);
        Time.timeScale = 1;

    }
        
}
