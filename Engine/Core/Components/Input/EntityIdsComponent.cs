﻿using Entitas;

namespace Lockstep.Core.Components.Input
{
    [Input]
    public class EntityIdsComponent : IComponent
    {
        public uint[] values;     
    }
}