using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI comboUI;

    int score = 0;
    int combo = 0;

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreUI.text = score.ToString();
        comboUI.text = combo.ToString() + " COMBO!!";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore()
    {
        score += 10;
        if (combo >= 2)
        {
            score += 10 + combo * 3;
        }
        scoreUI.text = score.ToString();

        combo += 1;
        comboUI.text = combo.ToString() + " COMBO!!";

    }

}
