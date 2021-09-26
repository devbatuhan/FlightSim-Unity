using UnityEditor;
using UnityEngine;

public static class Airplane_Menu
{
    [MenuItem("Airplane Tools/Create New Airplane")]
    public static void CreateNewAirplane()
    {
        var curSelected = Selection.activeGameObject;
        var currentCenterOfGravity = new GameObject("COG");
        var curController = curSelected.AddComponent<Airplane_Controller>();
        if (curSelected)
        {
            currentCenterOfGravity.transform.SetParent(curSelected.transform);
            curController.centerOfGravity = currentCenterOfGravity.transform;
        }
    }
}
