using UnityEngine;

public class Base_Airplane_Input : MonoBehaviour
{
   #region Variables
   protected float pitch = 0f;
   protected float roll = 0f;
   protected float yaw = 0f;
   protected float throttle = 0f;
   protected int flaps = 0;
   public int maxFlapIncrements;
   protected float brake = 0f;
   [SerializeField]protected KeyCode brakeKey = KeyCode.Space;
   #endregion
   
   #region Properties
   public float Pitch => pitch;
   public float Roll => roll;
   public float Yaw => yaw;
   public float Throttle => throttle;
   public int Flaps => flaps;
   public float Brake => brake;
   #endregion


   #region Built-in Metthods

   private void Start()
   {
      
   }
   
   private void Update()
   {
      HandleInputs();
   }
   #endregion
   
   
   
   #region Custom Methods
   protected virtual void HandleInputs()
   {
      //Process Main Control Inputs
      pitch = Input.GetAxis("Vertical");
      roll = Input.GetAxis("Horizontal");
      yaw = Input.GetAxis("Yaw");
      throttle = Input.GetAxis("Throttle");
      BrakeInputs();
      FlapsInputs();
   }

   protected virtual void BrakeInputs()
   {
      //Process Brake Inputs
      brake = Input.GetKey(brakeKey) ? 1f : 0f;
   }

   protected virtual void FlapsInputs()
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
   #endregion

}
