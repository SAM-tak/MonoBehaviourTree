﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MBT;

namespace MBTExample
{
    [AddComponentMenu("")]
    [MBTNode("Example/Set Random Position", 500)]
    public class SetRandomPosition : Leaf
    {
        public Bounds bounds;
        public Vector3Reference blackboardVariable;

        public override NodeResult Execute()
        {
            blackboardVariable.GetVariable().Value = new Vector3(
                Random.Range(bounds.min.x, bounds.max.x),
                Random.Range(bounds.min.y, bounds.max.y),
                Random.Range(bounds.min.z, bounds.max.z)
            );
            return NodeResult.success;
        }
    }
}
