using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class EasterEggs : MonoBehaviour
{

    public GameObject Cheat;
    public Transform Char,cam;
    private List<string> _keyStrokeHistory;

    void Awake() {
        _keyStrokeHistory = new List<string>();
    }

    void Update() {
        KeyCode keyPressed = DetectKeyPressed();
        AddKeyStrokeToHistory(keyPressed.ToString());
        if(GetKeyStrokeHistory().Equals("UpArrow,UpArrow,DownArrow,DownArrow,LeftArrow,RightArrow,LeftArrow,RightArrow,B,A")) {
            Cheat.SetActive(true);
            ClearKeyStrokeHistory();
        }
        if (GetKeyStrokeHistory().Equals("A,S,K,O,L,A,T,A"))
        {
            Char.position = new Vector3(0, -24.96f,0);
            cam.position = new Vector3(0, -24.96f, 0);
            ClearKeyStrokeHistory();
        }
    }

    private KeyCode DetectKeyPressed() {
        foreach(KeyCode key in Enum.GetValues(typeof(KeyCode))) {
            if(Input.GetKeyDown(key)) {
                return key;
            }
        }
        return KeyCode.None;
    }

    private void AddKeyStrokeToHistory(string keyStroke) {
        if(!keyStroke.Equals("None")) {
            _keyStrokeHistory.Add(keyStroke);
            if(_keyStrokeHistory.Count > 10) {
                _keyStrokeHistory.RemoveAt(0);
            }
        }
    }

    private string GetKeyStrokeHistory() {
        return String.Join(",", _keyStrokeHistory.ToArray());
    }

    private void ClearKeyStrokeHistory() {
        _keyStrokeHistory.Clear();
    }
}
