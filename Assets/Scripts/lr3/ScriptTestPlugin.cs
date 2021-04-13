using TestPlugin;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptTestPlugin : MonoBehaviour
{
    public static string CalculateString(string a, string b)
    {
        TestPluginSumString utils = new TestPluginSumString();
        return utils.AddValues(a, b);
    }
}