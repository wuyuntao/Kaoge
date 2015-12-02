using UnityEngine;
using System.Collections;
using System;

public class UIEventHandler : MonoBehaviour
{
    public ExpressionController head;

    public void OnClick(string expressionName)
    {
        head.Play(expressionName);
    }
}
