using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Combat.Runtime
{
    /// <summary>
    /// 增益
    /// </summary>
    public abstract class Buff : IBuff
    {
        public abstract UnityEvent OnDestroy { get; set; }
        public abstract int Sort { get; }
        public abstract void Awake();
        public abstract void Update();
        public abstract void Destroy();
        public abstract void Dispose();
    }
}