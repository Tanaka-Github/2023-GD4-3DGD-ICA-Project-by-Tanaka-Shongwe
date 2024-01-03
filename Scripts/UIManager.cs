using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    // Singleton pattern to allow accessing UIManager from other scripts
    public static UIManager Instance;


    // Reference to UI elements in the scene
    public GameObject examinePanel; // Panel to display object information
    public Text objectNameText;   // UI Text to display object name
    public Text objectDescriptionText; // UI Text to display object description



    private void Awake()
    {
        // Ensures only one instance of UIManager exists in the scene
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }


    // Function to show object information in the UI pop-up
    public void ShowObjectInfo(string objectName, string objectDescription)
    {
        // Update UI Text elements with object information
        objectNameText.text = objectName;
        objectDescriptionText.text = objectDescription;

        // Activate the UI pop-up panel
        examinePanel.SetActive(true);
    }

    // Function to close the UI pop-up panel
    public void CloseExaminePanel()
    {
        // Deactivate the UI pop-up panel
        examinePanel.SetActive(false);
    }
}
