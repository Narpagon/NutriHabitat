using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
    [SerializeField]
    private int _value;
    [HideInInspector] public GameObject myObject;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void ResetData()
    {
        myObject = null;
    }

    //[ContextMenu("SetToInitialValue")]
    //public void SetToInitialValue()
    //{

    //}
}

