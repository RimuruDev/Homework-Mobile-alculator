using UnityEngine;
using TMPro;
using UnityEngine.UI;

using RimuruDev.Math;

public sealed class CalcutorHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField numInputFieldOne;
    [SerializeField] private TMP_InputField numInputFieldTwo;
    [SerializeField] private TMP_InputField operatorInputField;
    [Space]
    [SerializeField] private Text[] numTexts;
    [SerializeField] private Text operatorText;
    [SerializeField] private Text resultText;

    public void Result()
    {
        if (CheckIsEmpty() != false) Debug.Log("String is empty or null. [Method(Result())]");

        var oneNum = int.Parse(numInputFieldOne.text);
        var twoNum = int.Parse(numInputFieldTwo.text);

        var userOperator = operatorInputField.text;

        numTexts[0].text = $"{oneNum}";
        numTexts[1].text = $"{twoNum}";

        operatorText.text = $"{userOperator}";

        switch (userOperator)
        {
            case "+": resultText.text = $"{Math.Addition(oneNum, twoNum)}"; break;
            case "-": resultText.text = $"{Math.Subtraction(oneNum, twoNum)}"; break;
            case "/": resultText.text = $"{Math.Division(oneNum, twoNum)}"; break;
            case "*": resultText.text = $"{Math.Multiply(oneNum, twoNum)}"; break;
        }
    }

    private bool CheckIsEmpty()
    {
        if (numInputFieldOne.text == "" || numInputFieldOne.text == null)
            Debug.Log("String is empty or null. [Method(CheckIsEmpty())]");

        if (numInputFieldTwo.text == "" || numInputFieldTwo.text == null)
            Debug.Log("String is empty or null. [Method(CheckIsEmpty())]");

        if (operatorInputField.text == "" || operatorInputField.text == null)
            Debug.Log("String is empty or null. [Method(CheckIsEmpty())]");

        return false;
    }
}
