using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExaminer : MonoBehaviour
{
    // Information about the object that will be displayed in the UI pop-up

    public string objectName = "Object";
    public string objectDescription = "This is an interactable object.";


    // Function to be called when the player examines the object
    public void ExamineObject()
    {
        // Display UI pop-up or log information about the object
        UIManager.Instance.ShowObjectInfo(objectName, objectDescription);
    }
}
