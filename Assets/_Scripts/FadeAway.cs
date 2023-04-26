using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(CountdownTimer))]

public class FadeAway : MonoBehaviour
{
    private CountdownTimer countdownTimer;
    private TextMeshProUGUI textUI;

    void Awake()
    {
        textUI = GetComponent<TextMeshProUGUI>();
        countdownTimer = GetComponent<CountdownTimer>();
    }

    void Start()
    {
        countdownTimer.ResetTimer(5);
    }

    void Update()
    {
        float alphaRemaining =
            countdownTimer.GetProportionTimeRemaining();
        print(alphaRemaining);
        Color c = textUI.color;
        c.a = alphaRemaining;
        textUI.color = c;
    }
}
