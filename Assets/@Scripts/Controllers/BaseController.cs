using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class BaseController : MonoBehaviour
{
    public ObjectType _objectType { get; protected set; }
    
    private void Awake()
    {
        init();
    }

    bool _init = false;

    public virtual bool init()
    {
        if (_init)
            return false;
        _init = true;
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
