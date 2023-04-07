using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CellController : MonoBehaviour
{
    [SerializeField] Color colorCorrect;
    [SerializeField] Color colorExist;
    [SerializeField] Color colorFail;
    [SerializeField] Color colorNone;

    [SerializeField] private Image background;
    [SerializeField] private TextMeshProUGUI text;

    public void UpdateText(char msg)
    {
        text.SetText(msg.ToString());
    }

    public void UpdateState(State state)
    {
        background.color = GetColor(state);
    }

    private Color GetColor(State state)
    {
        return state switch
        {
            State.None => colorNone,
            State.Exist => colorExist,
            State.Correct => colorCorrect,
            State.Fail => colorFail,
        };
    }
}

public enum State
{
    None,
    Exist,
    Correct,
    Fail,
}
