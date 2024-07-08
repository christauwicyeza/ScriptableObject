using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewScriptableObject", menuName = "Objects/MyScriptableObject", order = 1)]
public class MyScriptableObject : ScriptableObject
{
    public string title;
    public Texture icon;
}