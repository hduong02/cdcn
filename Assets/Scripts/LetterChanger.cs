using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterChanger : MonoBehaviour
{
    public TMP_Text text;
    private char c;
    // Start is called before the first frame update
    void Start()
    {
        RandomText();
    }

    private void RandomText()
    {
        c = (char)('A' + Random.Range(0, 26));
        text.text = c.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
