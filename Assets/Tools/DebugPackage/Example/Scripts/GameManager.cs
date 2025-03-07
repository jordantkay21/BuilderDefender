using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void Update()
    {
        DebugLogger.Log("Network", "This is a Network Log");
        DebugLogger.Log("Network", "This is a Network Warning Log", DebugLevel.Warning);
        DebugLogger.Log("Network", "This is a Network Error Log", DebugLevel.Error);
        DebugLogger.Log("UI", "This is a UI Log");
        DebugLogger.Log("GamePlay", "This is a GamePlay Log");
        DebugLogger.Log("PlayerController", "This is a PlayerController Log");
    }
}
