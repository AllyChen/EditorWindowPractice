using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(Player))] // use property of "Player"
//[CanEditMultipleObjects]
public class PlayerInspector2 : Editor
{
    Player player;
    SerializedProperty playerName;
    SerializedProperty playerHealth;

    void OnEnable()
    {
        player = (Player)target;
        playerName = serializedObject.FindProperty("playerName");
        playerHealth = serializedObject.FindProperty("health");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.BeginVertical();

        EditorGUILayout.PropertyField(playerName);

        if(playerHealth.floatValue < 20)
        {
            GUI.color = Color.red;
        }
        if (playerHealth.floatValue > 80)
        {
            GUI.color = Color.green;
        }
        EditorGUILayout.PropertyField(playerHealth);

        GUI.color = Color.white;

        EditorGUILayout.EndVertical();

        serializedObject.ApplyModifiedProperties();
    }
}