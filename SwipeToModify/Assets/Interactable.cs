using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    InteractableCubeBehaviour currentInteractableCube;


    // Update is called once per frame
    void Update()
    {

        DetectHandGestureSwipeLeft();
        DetectHandGestureSwipeRight();
        DetectHandGestureSwipeUp();
    }

    private void DetectHandGestureSwipeLeft()
    {
        HandInfo detectedHand = ManomotionManager.Instance.Hand_infos[0].hand_info;

        if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.SWIPE_LEFT)
        {
            if (currentInteractableCube)
            {
                currentInteractableCube.LeftInteraction();
            }

        }
    }

    private void DetectHandGestureSwipeRight()
    {
        HandInfo detectedHand = ManomotionManager.Instance.Hand_infos[0].hand_info;

        if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.SWIPE_RIGHT)
        {
            if (currentInteractableCube)
            {
                currentInteractableCube.RightInteraction();
            }
        }
    }

    private void DetectHandGestureSwipeUp()
    {
        HandInfo detectedHand = ManomotionManager.Instance.Hand_infos[0].hand_info;

        if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.SWIPE_UP)
        {
            if (currentInteractableCube)
            {
                currentInteractableCube.UpInteraction();
            }
        }
    }
}