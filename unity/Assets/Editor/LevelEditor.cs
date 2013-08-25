﻿using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(Level))]
public class LevelEditor : Editor {
    public override void OnInspectorGUI() {
        DrawDefaultInspector();
        Level level = (Level)target;
        string newName = "level-" + level.level;
        if(level.name != newName) {
            level.name = newName;
        }
    }
}
