using UnityEngine;
using UnityEngine.UI;

public class ScoreUIHandler : MonoBehaviour
{
    private const string SCORE_TEXT_OUTLINE = "---";
    
    [SerializeField] private Text _scoreText;

    public void UpdateText(int score)
    {
        _scoreText.text = SCORE_TEXT_OUTLINE  + score + SCORE_TEXT_OUTLINE ;
    }
}
