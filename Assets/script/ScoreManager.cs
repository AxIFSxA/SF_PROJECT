using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI nowScoreUI;

    public int nowScore;

    public TextMeshProUGUI bestScoreUI;

    public int bestScore;

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore" , 0);
        bestScoreUI.text = "Best Score : " + bestScore;
    }
}
