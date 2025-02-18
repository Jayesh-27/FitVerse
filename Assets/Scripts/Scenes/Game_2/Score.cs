using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    public int highScore;
    [SerializeField] TMP_Text T_Score;
    [SerializeField] TMP_Text T_HighScore;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    void Update()
    {
        T_Score.text = score.ToString();
        T_HighScore.text = highScore.ToString();
        if(score > highScore )
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }        
    }
}