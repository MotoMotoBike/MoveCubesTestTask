using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistChanger : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    
    public void ChangeValue()
    {
        string text = GetComponent<TMP_InputField>().text;
        float value = (float)Convert.ToDouble(text);
        if (value != null && value > 0)
        {
            spawner.stats.destroyDist = value;
        }
    }
}
