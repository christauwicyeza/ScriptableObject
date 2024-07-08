using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class NewBehaviourScript : MonoBehaviour
{
    public MyScriptableObject ScriptableObject; 
    public TMP_Text titleText; 
    public RawImage iconImage; 

    void Start()
    {

    }

    public void UpdateUI()
    {
        // Display title text and icon
        titleText.text = ScriptableObject.title;
        iconImage.texture = ScriptableObject.icon;
    }
}
