using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "NewTextContent", menuName = "ScriptableObjects/TextContents", order = 1)]
public class TextContents : ScriptableObject
{
    // this is the title of the text box - name of character?
    public string title;
    // this is the content of the text box
    public string content;
    // this will be displayed as the button text
    public string response;
}

[CustomEditor(typeof(TextContents))][CanEditMultipleObjects]
public class TextContentsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        TextContents myTarget = (TextContents)target;

        myTarget.title = EditorGUILayout.TextField("Title", myTarget.title);
        myTarget.content = EditorGUILayout.TextArea(myTarget.content, GUILayout.MaxHeight(75));
        myTarget.response = EditorGUILayout.TextField("Title", myTarget.response);
    }

}