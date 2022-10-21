using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBar : MonoBehaviour
{
    private int _score = 0;

    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            Refresh();
        }
    }

    private void Awake()
    {
    }

    private void Refresh()
    {
        transform.GetComponent<UnityEngine.UI.Text>().text = _score.ToString();
    }
}
