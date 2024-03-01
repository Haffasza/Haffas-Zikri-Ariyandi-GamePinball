using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;

    private void Start()
    {
        ResetScore();
    }

    // Start is called before the first frame update
    public void AddScore(float addition)
    {
        score += addition;
    }

    // Update is called once per frame
    public void ResetScore()
    {
        score = 0;
    }
}
