using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(Player))] // use property of "Player"
public class PlayerInspector : Editor {

    Player player;
    bool showWeapons;
    EditorWindow window;

    void OnEnable()
    {
        player = (Player)target;
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("Player id " + player.id);
        player.playerName = EditorGUILayout.TextField("Player Name ", player.playerName);
        

        EditorGUILayout.LabelField("Back Story");
        player.littleBackStory = EditorGUILayout.TextArea(player.littleBackStory, GUILayout.MinHeight(70));

        if (player.health < 20)
            GUI.color = Color.red;
        if (player.health > 80)
            GUI.color = Color.green;
        // below this will change color to red or green
        //player.health = EditorGUILayout.FloatField("Health", player.health);

        // Cool Rect ProgressBar
        Rect progressRect = GUILayoutUtility.GetRect(50, 50);
        EditorGUI.ProgressBar(progressRect, player.health / 100.0f, "Health");

        GUI.color = Color.white;

        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        player.damage = EditorGUILayout.Slider("Damage ", player.damage, 10, 20);

        if(player.damage < 12)
            EditorGUILayout.HelpBox("The damage is too low !", MessageType.Warning);
  
        if(player.damage > 18)
            EditorGUILayout.HelpBox("The damage is too high !", MessageType.Warning);
        

        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        showWeapons = EditorGUILayout.Foldout(showWeapons, "Weapons");

        if (showWeapons)
        {
            EditorGUI.indentLevel += 2; // indentLevel
            player.weapon1Damage = EditorGUILayout.FloatField("Weapon 1 Damage ", player.weapon1Damage);
            player.weapon2Damage = EditorGUILayout.FloatField("Weapon 2 Damage ", player.weapon2Damage);
            EditorGUI.indentLevel -= 2; // indentLevel
        }

        EditorGUILayout.LabelField("Shoe");

        //EditorGUILayout.BeginHorizontal();
        //EditorGUILayout.LabelField("Name ", GUILayout.MaxWidth(40));
        //player.shoeName = EditorGUILayout.TextField(player.shoeName);
        //EditorGUILayout.LabelField("Size ", GUILayout.MaxWidth(40));
        //player.shoeSize = EditorGUILayout.IntField(player.shoeSize);
        //EditorGUILayout.LabelField("Type ", GUILayout.MaxWidth(40));
        //player.shoeType = EditorGUILayout.TextField(player.shoeType);
        //EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();
        EditorGUILayout.Space();

        #region Random Name
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Random Name"))
        {
            player.ButtonCallFromInspector();
        }
        if (GUILayout.Button("Random Name"))
        {
            player.ButtonCallFromInspector();
        } 
        EditorGUILayout.EndHorizontal();
        #endregion
        #region Window
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Create Window"))
        {
            //MyFirstEditorWindow.ShowWindow();
            window = MyFirstEditorWindow.ShowWindow2();
        }
        if (GUILayout.Button("Close Window"))
        {
            window.Close();
        }
        EditorGUILayout.EndHorizontal();
        #endregion

        EditorGUILayout.EndVertical();

        player.health += 2;
        if (player.health > 100)
            player.health = 0;
    }

}
