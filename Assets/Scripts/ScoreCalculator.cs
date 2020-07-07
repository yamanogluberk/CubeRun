using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{

    public Transform endLine;
    public Text scoreText;

    private float initialPos;
    
    private void Start()
    {
        initialPos = endLine.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (initialPos - endLine.position.z).ToString("0");
    }
}
