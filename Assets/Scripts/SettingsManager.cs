using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Text TitleText;
    public Text InstructionsText;
    public InputField NameField;
    public Text NameText;
    public Dropdown ColorDropdown;
    public Text ColorText;
    public Slider SpeedSlider;
    public Text SliderText;
    public Text SpeedText;

    public static string PlayerName = "default";
    public static int TextColor = 0;
    public static float FallSpeed = 1.0f;

    void Update()
    {
        NameText.text = NameField.text;
        PlayerName = NameField.text;

        switch (ColorDropdown.value)
        {
            case 0:
                TitleText.color = Color.black;
                InstructionsText.color = Color.black;
                NameText.color = Color.black;
                ColorText.color = Color.black;
                SliderText.color = Color.black;
                SpeedText.color = Color.black;
                TextColor = 0;
                break;
            case 1:
                TitleText.color = Color.blue;
                InstructionsText.color = Color.blue;
                NameText.color = Color.blue;
                ColorText.color = Color.blue;
                SliderText.color = Color.blue;
                SpeedText.color = Color.blue;
                TextColor = 1;
                break;
            case 2:
                TitleText.color = Color.green;
                InstructionsText.color = Color.green;
                NameText.color = Color.green;
                ColorText.color = Color.green;
                SliderText.color = Color.green;
                SpeedText.color = Color.green;
                TextColor = 2;
                break;
            default:
                TitleText.color = Color.black;
                InstructionsText.color = Color.black;
                NameText.color = Color.black;
                ColorText.color = Color.black;
                SliderText.color = Color.black;
                SpeedText.color = Color.black;
                TextColor = 0;
                break;
        }

        SpeedText.text = SpeedSlider.value.ToString("f2");
        FallSpeed = SpeedSlider.value;
    }
}
