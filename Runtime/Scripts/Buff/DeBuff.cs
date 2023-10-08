
using UnityEngine.Events;

namespace Combat.Runtime
{
    /// <summary>
    /// 负面增益
    /// </summary>
    public abstract class DeBuff : IBuff
    {
        public abstract int Sort { get; }
        
        public abstract UnityEvent OnDestroy { get; set; }
        
        public abstract void Awake();
        public abstract void Update();
        public abstract void Destroy();
        public abstract void Dispose();
    }
}