using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Xbox_Airplane_Input))]
public class XboxAirplaneInput_Editor : Editor
{
    #region Variables
    private Base_Airplane_Input targetInput;
    #endregion
    
    #region Built-in Methods
    private void OnEnable()
    {
        targetInput = target as Xbox_Airplane_Input;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        string debugInfo = "";
        debugInfo += "Pitch =" + targetInput.Pitch + "\n";
        debugInfo += "Roll =" + targetInput.Roll + "\n";
        debugInfo += "Yaw =" + targetInput.Yaw + "\n";
        debugInfo += "Throttle =" + targetInput.Throttle + "\n";
        debugInfo += "Brake =" + targetInput.Brake + "\n";
        debugInfo += "Flaps =" + targetInput.Flaps + "\n";
        
        //Custom Editor Code
        GUILayout.Space(20);
        EditorGUILayout.TextArea(debugInfo, GUILayout.Height(100));
        GUILayout.Space(20);
        
        Repaint();
    }
    #endregion
    

}
