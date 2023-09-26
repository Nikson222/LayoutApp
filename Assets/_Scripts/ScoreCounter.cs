using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int _score;

    [SerializeField] private ActionButton _button;
    [SerializeField] ScoreUIHandler _UIhandler;

    private void Start()
    {
        _button.AddListenerOnClick(IncreaseScore);
        _button.AddListenerOnClick(() => _UIhandler.UpdateText(_score));
    }

    private void IncreaseScore() => _score++;


}
