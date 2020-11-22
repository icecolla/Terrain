using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(generateTerrain))]
public class TerrainBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        generateTerrain myScript = (generateTerrain)target;

        if (GUILayout.Button("Generate Terrain"))
        {
            myScript.Start();
        }
    }
}

[CustomEditor(typeof(paintTerrain))]
public class TerrainPaintEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        paintTerrain myScript = (paintTerrain)target;

        if (GUILayout.Button("Paint Terrain"))
        {
            myScript.Start();
        }
    }
}