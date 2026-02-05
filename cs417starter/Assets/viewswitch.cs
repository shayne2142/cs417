using UnityEngine;
using UnityEngine.InputSystem; 

public class viewswitch : MonoBehaviour
{
    //[Header("Settings")]
    public Transform externalViewPoint; 

    
    private Vector3 roomPosition;
    private Quaternion roomRotation;

    private bool isExternal = false;

    void Start()
    {
       
        roomPosition = transform.position;
        roomRotation = transform.rotation;
    }

    void Update()
    {
        
        if (Keyboard.current != null && Keyboard.current.cKey.wasPressedThisFrame)
        {
            TogglePosition();
        }
    }

    void TogglePosition()
    {
        isExternal = !isExternal;

        if (isExternal)
        {
            
            transform.position = externalViewPoint.position;
            transform.rotation = externalViewPoint.rotation;
        }
        else
        {
           
            transform.position = roomPosition;
            transform.rotation = roomRotation;
        }
    }
}
