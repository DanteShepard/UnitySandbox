using UnityEngine;
using UnityEditor;

public class MenuItems
{
    [MenuItem("Tools/Build")]
    private static void NewMenuOption()
    {
        Nordeus.Build.Builder.BuildAndroid("D://alfa_apk.");
    }

}