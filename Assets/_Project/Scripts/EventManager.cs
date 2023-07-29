using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ResetAction();
    public static event ResetAction OnReset;
    // Start is called before the first frame update
    public void Reset()
    {
        OnReset?.Invoke();
    }
}
