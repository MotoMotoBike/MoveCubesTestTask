using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedChanger : MonoBehaviour
{
    [SerializeField] private Spawner spawner;

    public void ChangeValue()
    {
        float value = (float)Convert.ToDouble(this.GetComponent<TMP_InputField>().text);
        if (value != null && value > 0)
        {
            spawner.stats.speed = value;
        }
    }
}
