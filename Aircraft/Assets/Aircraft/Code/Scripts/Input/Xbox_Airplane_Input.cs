using UnityEngine;

public class Xbox_Airplane_Input : Base_Airplane_Input
{
    protected override void HandleInputs()
    {
        //Process Main Control Inputs
        pitch = Input.GetAxis("Vertical");
        roll = Input.GetAxis("Horizontal");
        yaw = Input.GetAxis("Yaw");
        throttle = Input.GetAxis("Throttle");
    }
    
    protected override void BrakeInputs()
    {
        //Process Brake Inputs
        brake = Input.GetAxis("Fire1");
    }

    protected override void FlapsInputs()
    {
        //Process Flaps Inputs
        if (Input.GetKeyDown(KeyCode.F))
        {
            flaps += 1;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            flaps -= 1;
        }
        flaps = Mathf.Clamp(flaps, 0, maxFlapIncrements);
    }
}
