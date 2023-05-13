using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterChanger : MonoBehaviour
{
    public TMP_Text text;
    [SerializeField] char letter;

    // Start is called before the first frame update
    void Start()
    {
        RandomLetter();
        changeText();
    }

    public void RandomLetter()
    {
        letter = (char)('A' + Random.Range(0, 26));
    }

    private void changeText() {
        text.text = letter.ToString();
    }

    public char getLetter() {
        return letter;
    }


    // Update is called once per frame
    void Update()
    {
        changeText();
    }
}
