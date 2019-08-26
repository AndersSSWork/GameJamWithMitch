using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewHintContent", menuName = "ScriptableObjects/HintContent", order = 2)]
public class HintContent : ScriptableObject
{
    public string hintGiver;
    public string hintContent;
    public Color hintColor;
}
