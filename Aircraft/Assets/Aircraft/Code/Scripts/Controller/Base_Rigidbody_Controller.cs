using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(AudioSource))]
public class Base_Rigidbody_Controller : MonoBehaviour
{
    #region Variables

    protected Rigidbody rb;
    protected AudioSource aSource;
    
    #endregion

    #region Built-in Methods
    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        aSource = GetComponent<AudioSource>();
        if (aSource)
        {
            aSource.playOnAwake = false;
        }
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            HandlePhysics();
        }
    }
    #endregion


    #region Custom Methods
    protected virtual void HandlePhysics(){}
    #endregion
}
