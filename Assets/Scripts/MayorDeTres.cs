using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MayorDeTres : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    public TMP_InputField inputNum3;

    public TMP_Text txtGreater;

    void Start()
    {
        txtGreater.text = "?";
    }

    public void Button_CualEsMayor()
    {
        int num1 = int.Parse(inputNum1.text);
        int num2 = int.Parse(inputNum2.text);
        int num3 = int.Parse(inputNum3.text);
        txtGreater.text = GetGreaterOfTree(num1,num2,num3).ToString();
    } 
    private int GetGreaterOfTree(int num1, int num2, int num3)
    {
        int greater = 0;
        if (num1 > num2)
        {
            greater = num1;
        }
        else
        {
            greater = num2;
        }

        if (num3 > greater)
        {
            greater = num3;
        }
        return greater;
    }
}
