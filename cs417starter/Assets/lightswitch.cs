using UnityEngine;
using UnityEngine.InputSystem; 

public class LightSwitchToggle : MonoBehaviour
{
    public Light targetLight;

    private Color originalColor; 
    private bool isViolet = false; 

    void Start()
    {
        targetLight = GetComponent<Light>();

        
        originalColor = targetLight.color;
    }

    void Update()
    {
        
        if (Keyboard.current != null && Keyboard.current.tabKey.wasPressedThisFrame)
        {
            ToggleColor();
        }
    }

    void ToggleColor()
    {
        
        isViolet = !isViolet;

        
        if (isViolet)
        {
            targetLight.color = Color.violet;
        }
        else
        {
            targetLight.color = originalColor; 
        }
    }
}