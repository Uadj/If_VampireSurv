using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : CreatureController
{
    public override bool init()
    {
        if (base.init())
            return false;

        _objectType = Define.ObjectType.Monster;

        return true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
