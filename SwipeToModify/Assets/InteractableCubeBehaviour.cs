using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCubeBehaviour : MonoBehaviour
{
    bool shouldSpin;
    bool spinHorizontalLeft;
    bool spinHorizontalRight;

    bool isHighlighted;

    //Feel free to choose your own colors
    public Color idleColor = Color.blue;
    public Color isHighliughtedColor = Color.red;
    MeshRenderer cubeMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        cubeMeshRenderer = this.GetComponent<MeshRenderer>();
        shouldSpin = false;
        spinHorizontalLeft = false;
        spinHorizontalRight = false;
        isHighlighted = false;
        UpdateColor();
    }

    private void FixedUpdate()
    {
        SpinBehavior();
    }


    /// <summary>
    /// Basic behavior of the SpiningCube 
    /// </summary>
    void SpinBehavior()
    {
        if (shouldSpin)
        {
            this.transform.Rotate(0, 1, 1);
        }
        else if (spinHorizontalLeft)
        {
            this.transform.Rotate(1, 0, 0);
        }
        else if (spinHorizontalRight)
        {
            this.transform.Rotate(0, 1, 0);
        }
    }


    /// <summary>
    /// Updates the cubes material color according to the status (isActivated or Not)
    /// </summary>
    private void UpdateColor()
    {
        if (isHighlighted)
        {
            cubeMeshRenderer.material.color = isHighliughtedColor;
        }
        else
        {
            cubeMeshRenderer.material.color = idleColor;
        }
    }

    /// <summary>
    /// Toggles the cubes activation value (isActive or Not)
    /// </summary>
    private void ToggleHighlight()
    {
        isHighlighted = !isHighlighted;
    }

    /// <summary>
    /// The code logic of the interaction. In our example, Toggle the status and update the visuals.
    /// </summary>
    public void LeftInteraction()
    {
        ToggleHighlight();
        UpdateColor();
        shouldSpin = false;
        spinHorizontalLeft = true;
        spinHorizontalRight = false;
    }

    public void RightInteraction()
    {
        ToggleHighlight();
        UpdateColor();
        shouldSpin = false;
        spinHorizontalLeft = false;
        spinHorizontalRight = true;
    }

    public void UpInteraction()
    {
        ToggleHighlight();
        UpdateColor();
        shouldSpin = true;
        spinHorizontalLeft = false;
        spinHorizontalRight = false;
    }
}
