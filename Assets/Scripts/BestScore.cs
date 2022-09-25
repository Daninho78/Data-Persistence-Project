using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScore : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bestScoreText.text = "Best Score : " + SaveManager.Instance.bestScoreName + " : " + SaveManager.Instance.bestScore;
    }
}
