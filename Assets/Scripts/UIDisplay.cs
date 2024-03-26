using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    Player player;
    ScoreKeeper scoreKeeper;
    Slider slider;
    TextMeshProUGUI text;
    Health health;
    float maxHealth;
    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        player = FindObjectOfType<Player>();
        slider = GetComponentInChildren<Slider>();
        text = GetComponentInChildren<TextMeshProUGUI>();
        health = player.GetComponent<Health>();
    }
    void Start(){
        maxHealth = health.GetHealth();
    }

    void Update()
    {
        slider.value = health.GetHealth()/maxHealth;
        text.text = scoreKeeper.GetScore().ToString("000000000");
    }
}
