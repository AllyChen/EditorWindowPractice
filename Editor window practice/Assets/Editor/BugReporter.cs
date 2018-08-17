using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class BugReporter : EditorWindow {

    string bugReportName = "";
    string description = "";
    GameObject buggyGameObject;

    [MenuItem("Tools/BugReporter")]
    public static void ShowWindow()
    {
        GetWindow(typeof(BugReporter));
    }

    public BugReporter()
    {
        titleContent = new GUIContent("Bug Reporter");
    }

    void OnGUI()
    {
        GUILayout.BeginVertical();

        GUILayout.Space(10);
        GUI.skin.label.fontSize = 24;
        GUI.skin.label.alignment = TextAnchor.MiddleCenter;
        GUILayout.Label("Bug Reporter");
        GUI.skin.label.fontSize = 12;
        GUI.skin.label.alignment = TextAnchor.UpperLeft;

        GUILayout.Space(10);
        bugReportName = EditorGUILayout.TextField("Bug Name", bugReportName);
        GUILayout.Space(10);
        GUILayout.Label("Scene : " + EditorApplication.currentScene);
        GUILayout.Space(10);
        GUILayout.Label("Time : " + System.DateTime.Now.ToString());

        GUILayout.Space(10);
        buggyGameObject = (GameObject)EditorGUILayout.ObjectField("Buggy Game Object", buggyGameObject, typeof(GameObject), true);
        GUILayout.Space(10);
        GUILayout.BeginHorizontal();
        GUILayout.Label("Description", GUILayout.MaxWidth(80));
        description = EditorGUILayout.TextArea(description, GUILayout.MaxHeight(75));
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        if (GUILayout.Button("Save Bug"))
        {
            SaveBug();
        }

        GUILayout.Space(10);
        if (GUILayout.Button("Save Bug With Screenshot"))
        {
            SaveBugWithScreenshot();
        }

        GUILayout.EndVertical();
    }

    void SaveBug()
    {
        Directory.CreateDirectory("Assets/BugReports/" + bugReportName);
        StreamWriter sw = new StreamWriter("Assets/BugReports/" + bugReportName + "/" + bugReportName + ".txt");
        sw.WriteLine(bugReportName);
        sw.WriteLine(System.DateTime.Now.ToString());
        sw.WriteLine(EditorApplication.currentScene);
        sw.WriteLine(description);
        sw.Close();
    }

    void SaveBugWithScreenshot()
    {
        Directory.CreateDirectory("Assets/BugReports/" + bugReportName);
        StreamWriter sw = new StreamWriter("Assets/BugReports/" + bugReportName + "/" + bugReportName + ".txt");
        sw.WriteLine(bugReportName);
        sw.WriteLine(System.DateTime.Now.ToString());
        sw.WriteLine(EditorApplication.currentScene);
        sw.WriteLine(description);
        sw.Close();

        Application.CaptureScreenshot("Assets/BugReports/" + bugReportName + "/" + bugReportName + "Screenshot" +".png");
    }

}
