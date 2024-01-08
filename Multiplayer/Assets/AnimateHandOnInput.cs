using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    private void OnEnable()
    {
        // Enable the action
        pinchAnimationAction.action.Enable();
    }

    private void OnDisable()
    {
        // Disable the action
        pinchAnimationAction.action.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (pinchAnimationAction.action.enabled)
        {
            float triggerValue = pinchAnimationAction.action.ReadValue<float>();
            handAnimator.SetFloat("Trigger", triggerValue);

	    float gripValue = gripAnimationAction.action.ReadValue<float>();
	    handAnimator.SetFloat("Grip", gripValue);
        }
    }
}
