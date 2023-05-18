using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameSaver : MonoBehaviour
{
    [SerializeField] TMP_InputField text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onClick() {
        string name = text.text;
        PlayerPrefs.SetString("name", name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
