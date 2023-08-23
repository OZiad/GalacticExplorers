using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrosshairController : MonoBehaviour
{
    [SerializeField] private RectTransform canvasRect;

    private void Update()
    {
        // Get the mouse position in screen coordinates
        Vector3 mousePosition = Input.mousePosition;

        // Convert screen coordinates to world coordinates (for a 2D game)
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.nearClipPlane));
        worldPosition.z = 0f; // Set the Z position to the same as your crosshair

        // Update the crosshair's position
        transform.position = worldPosition;

        // Ensure the crosshair stays within the canvas boundaries
        ClampToCanvas();
    }

    void ClampToCanvas()
    {
        // Get the canvas size in screen coordinates
        Vector3 canvasSize = canvasRect.rect.size;
        Vector3 halfCanvasSize = canvasSize * 0.5f;

        // Clamp the crosshair's position to stay within canvas boundaries
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -halfCanvasSize.x, halfCanvasSize.x);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -halfCanvasSize.y, halfCanvasSize.y);
        transform.position = clampedPosition;
    }
}

