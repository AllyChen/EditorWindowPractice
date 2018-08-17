using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AI))]
public class AIInspector : Editor {

    AI ai;

    void OnEnable()
    {
        ai = (AI)target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }

    void OnSceneGUI()
    {
        Handles.Label(ai.transform.position + new Vector3(0, 5, 0), "Deadly AI : " + ai.name);
        //ai.areaRedius = Handles.RadiusHandle(Quaternion.identity, ai.transform.position, ai.areaRedius); //TEST Gizmos
        ai.speed = Handles.ScaleValueHandle(ai.speed, ai.transform.position, Quaternion.identity, ai.speed, Handles.ArrowCap, 0.5f);

        // Position of points
        if(ai.showNodeHandles)
        {
            //for (int i = 0; i < ai.nodePoints.Length; i++) //TEST Gizmos           
            //ai.nodePoints[i] = Handles.PositionHandle(ai.nodePoints[i], ai.nodePointsRotations[i]); //TEST Gizmos            
        }
        // Line       
        Handles.color = Color.blue;
        //for(int i = 0; i < ai.nodePoints.Length; i++) //TEST Gizmos
        //Handles.DrawLine(ai.nodePoints[i], ai.nodePoints[(int)Mathf.Repeat(i+1, ai.nodePoints.Length)]); //TEST Gizmos
        // Rotation of points
        if (ai.showNodeHandles)
        {
            //for (int i = 0; i < ai.nodePointsRotations.Length; i++) //TEST Gizmos
            //ai.nodePointsRotations[i] = Handles.RotationHandle(ai.nodePointsRotations[i], ai.nodePoints[i]); //TEST Gizmos
        }
        #region Button
        //Handles.BeginGUI();

        //GUILayout.BeginVertical();

        //GUILayout.BeginArea(new Rect(32, 20, 100, 100));
        //GUILayout.Label("Ally");
        //GUILayout.EndArea();

        //GUILayout.BeginArea(new Rect(20, 50, 50, 500));   
        //if(GUILayout.Button("TEST", GUILayout.MinHeight(50)))
        //    Debug.Log("TEST");
        //if (GUILayout.Button("TEST", GUILayout.MinHeight(50)))
        //    Debug.Log("TEST");
        //if (GUILayout.Button("TEST", GUILayout.MinHeight(50)))
        //    Debug.Log("TEST");
        //if (GUILayout.Button("TEST", GUILayout.MinHeight(50)))
        //    Debug.Log("TEST");
        //if (GUILayout.Button("TEST", GUILayout.MinHeight(50)))
        //    Debug.Log("TEST");
        //GUILayout.EndArea();

        //GUILayout.EndVertical();

        //Handles.EndGUI();
        #endregion
    }

}
