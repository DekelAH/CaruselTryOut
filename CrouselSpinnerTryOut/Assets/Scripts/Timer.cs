using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    #region Editor

    [Header("Text Components")]
    [SerializeField]
    private TextMeshProUGUI _firstSecond;

    [SerializeField]
    private TextMeshProUGUI _secondSecond;

    [SerializeField]
    private TextMeshProUGUI _firstMinute;

    [SerializeField]
    private TextMeshProUGUI _secondMinute;

    #endregion

    #region Fields

    private float _currentTime;

    #endregion

    #region Methods

    private void Update()
    {
        UpdateTimer();
        UpdateTimerDisplay(_currentTime);
    }

    private void UpdateTimerDisplay(float time)
    {
        var minutes = Mathf.FloorToInt(time / 60);
        var seconds = Mathf.FloorToInt(time % 60);

        var currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        _secondMinute.text = currentTime[0].ToString();
        _firstMinute.text = currentTime[1].ToString();
        _secondSecond.text = currentTime[2].ToString();
        _firstSecond.text = currentTime[3].ToString();
    }

    private void UpdateTimer()
    {
        _currentTime += Time.deltaTime;
    }

    #endregion
}
