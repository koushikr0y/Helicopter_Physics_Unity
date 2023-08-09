using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum InputType
{
    KeyBoard,
    Mobile,
}

public class Input_Controllers : MonoBehaviour
{
    #region variable
    public InputType inputType = InputType.KeyBoard;
    private float throttleInput;
    private float collectiveInput;
    private Vector2 cyclicInput;
    private float pedalInput;
    private float stickyThrottle;
    private float stickyCollective;
    private KeyboardHeli_Input keyInput;
    #endregion

    #region Properties
    public float ThrottleInput { get { return throttleInput; } private set { } }
    public float CollectiveInput { get { return collectiveInput; } private set { } }
    public Vector2 CyclicInput { get { return cyclicInput; } private set { } }
    public float PedalInput { get { return pedalInput; } private set { } }

    public float StickyThrottle { get { return stickyThrottle; } private set { } }
    public float StickyCollective { get { return stickyCollective; } private set { } }
    #endregion

    private void Start()
    {
        keyInput = GetComponent<KeyboardHeli_Input>();
    }

    private void Update()
    {
        switch (inputType)
        {
            case InputType.KeyBoard:
                throttleInput = keyInput.ThrottleInput;
                collectiveInput = keyInput.CollectiveInput;
                cyclicInput = keyInput.CyclicInput;
                pedalInput = keyInput.PedalInput;
                stickyThrottle = keyInput.StickyThrottleInput;
                stickyCollective = keyInput.StickyCollectiveleInput;
                break;
        }
    }

    void SetInputType(InputType type)
    {

    }
}
