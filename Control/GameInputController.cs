using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class GameInputController : MonoBehaviour
{
    public static GameInputController Instance;

    public event EventHandler OnJumpActionPerformed;
    public event EventHandler OnDownActionPerformed;
    public event EventHandler OnRightActionPerformed;
    public event EventHandler OnLeftActionPerformed;
    public event EventHandler OnEscActionPerformed;
    public event EventHandler OnDashActionPerformed;
    public event EventHandler OnInteractionClickedPerformed;


    public InGameInputAction InGameInputAction;

    public Vector2 test;


    private void Awake()
    {
        Instance = this;

        
    }
    
    
    private void Start()
    {
        StartCoroutine(InputInitialization());
    }
    
    public IEnumerator InputInitialization()
    {
        InGameInputAction = new InGameInputAction();
        InGameInputAction.Enable(); ;

        yield return new WaitForSeconds(0.1f);

        InGameInputAction.PlayerImputs.Jump.performed += JumpActionPerformed;
        InGameInputAction.PlayerImputs.Down.performed += DownActionPerformed;

        InGameInputAction.PlayerImputs.Esc.performed += EscActionPerformed;
        InGameInputAction.PlayerImputs.Dash.performed += DashActionPerformed;
        InGameInputAction.PlayerImputs.Interaction.performed += InteractionClickedPerformed;
        //yield return null;
    }
    
    private void JumpActionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnJumpActionPerformed?.Invoke(this, EventArgs.Empty);
    }
    
    private void DownActionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {

        OnDownActionPerformed?.Invoke(this, EventArgs.Empty);
    }
    
    private void RightActionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnRightActionPerformed?.Invoke(this, EventArgs.Empty);
    }

    private void LeftActionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnLeftActionPerformed?.Invoke(this, EventArgs.Empty);
    }

    private void EscActionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnEscActionPerformed?.Invoke(this, EventArgs.Empty);
    }
    
    private void DashActionPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnDashActionPerformed?.Invoke(this, EventArgs.Empty);
    }

    private void InteractionClickedPerformed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractionClickedPerformed?.Invoke(this, EventArgs.Empty);
    }
    
    public Vector2 GetMovementVectorNormalized()
    {
        //Debug.Log("Moved performed");
        Vector2 inputVector = InGameInputAction.PlayerImputs.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        return inputVector;
    }

}
