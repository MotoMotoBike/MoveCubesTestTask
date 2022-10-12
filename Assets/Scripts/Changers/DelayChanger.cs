using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DelayChanger : MonoBehaviour
{
    [SerializeField] private Spawner spawner;
    
    public void ChangeValue()
    {
        float value = (float)Convert.ToDouble(gameObject.GetComponent<TMP_InputField>().text);
        if (value != null && value > 0)
        {
            spawner.delay = value;
        }
    }
}
