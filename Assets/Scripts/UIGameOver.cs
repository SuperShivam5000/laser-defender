using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    void Awake(){
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start(){
        scoreText.text="You Scored:\n" + scoreKeeper.GetScore();
    }

}
