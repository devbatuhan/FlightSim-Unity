using System.Collections.Generic;
using UnityEngine;

public class Airplane_Controller : Base_Rigidbody_Controller
{
    #region Variables
    
    [Header("Base Airplane Properties")]
    public Base_Airplane_Input input;
    public Transform centerOfGravity;
    
    [Tooltip("Weight is in Kilograms")]
    public float airplaneWeight = 800f;

    [Header("Engines")] 
    [SerializeField] private List<Airplane_Engine> engines = new List<Airplane_Engine>();

    [Header("Wheels")] [SerializeField] private List<Airplane_Wheel> wheels = new List<Airplane_Wheel>();
    
    #endregion

    public override void Start()
    {
        base.Start();
        if (rb)
        {
            if (centerOfGravity)
            {
                rb.centerOfMass = centerOfGravity.localPosition;
            }
        }

        if (wheels?.Count > 0)
        {
            foreach (Airplane_Wheel wheel in wheels)
            {
                    
            }
        }
    }

    #region Custom Methods
    protected override void HandlePhysics()
    {
        if (input)
        {
            HandleEngines();
            HandleAeroDynamics();
            HandleSteering();
            HandleBrakes();
            HandleAltitude();
        }
        
    }

    private void HandleEngines()
    {
        if (engines?.Count > 0)
        {
            foreach (Airplane_Engine engine in engines)
            {
                engine.CalculateForce(input.Throttle);
            }
        }
    }

    private void HandleAeroDynamics()
    {
        throw new System.NotImplementedException();
    }

    private void HandleSteering()
    {
        throw new System.NotImplementedException();
    }

    private void HandleBrakes()
    {
        throw new System.NotImplementedException();
    }

    private void HandleAltitude()
    {
        throw new System.NotImplementedException();
    }

    #endregion
}
