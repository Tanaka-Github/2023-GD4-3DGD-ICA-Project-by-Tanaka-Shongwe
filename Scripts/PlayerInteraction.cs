using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private Camera mainCamera; // Reference to the main camera
    private RaycastHit hit; // Raycast hit information

    private void Start()
    {
        // Get the main camera reference at the start
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            // Perform a raycast and check for collisions
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the collided object has an ObjectExaminer component
                ObjectExaminer examiner = hit.collider.GetComponent<ObjectExaminer>();

                // If an ObjectExaminer component exists, trigger examination
                if (examiner != null)
                {
                    examiner.ExamineObject();
                }
            }
        }
    }
}
