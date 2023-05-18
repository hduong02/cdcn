using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointChanger : MonoBehaviour
{
    const int AVAILABLE_TURNS = 3;
    int finalPoint = 0;
    public TMP_Text text;
    public TMP_Text finalPointText;
    public TMP_Text nameText;
    [SerializeField] GameObject backButton;
    [SerializeField] GameObject pointPanel;
    [SerializeField] NewObserverEventHandler[] observerEventHandlers;
    [SerializeField] GameObject totalPointMessage;

    // Start is called before the first frame update
    void Start()
    {
        totalPointMessage.SetActive(false);
        changeText();
    }

    private void changeText() 
    {
        int point = 0;
        foreach (NewObserverEventHandler observerEventHandler in observerEventHandlers) 
        {
            point += observerEventHandler.getPoint();
        }
        text.text = point.ToString();
    }

    private void CheckMessageCondition() 
    {
        int point = 0;
        int turnUsed = 0;
        foreach (NewObserverEventHandler observerEventHandler in observerEventHandlers) 
        {
            point += observerEventHandler.getPoint();
            turnUsed += observerEventHandler.getTurnUsed();
        }
        
        if (turnUsed == AVAILABLE_TURNS) {
            totalPointMessage.SetActive(true);
            backButton.SetActive(false);
            pointPanel.SetActive(false);
            finalPoint = point;
            finalPointText.text = "You got " + finalPoint +" points.";
            string name = PlayerPrefs.GetString("name");
            nameText.text = "Congratulate " + name;
        }
    }
    // Update is called once per frame
    void Update()
    {
        changeText();
        CheckMessageCondition();
    }
}
