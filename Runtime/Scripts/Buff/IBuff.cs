using System;
using UnityEngine.Events;

namespace Combat.Runtime
{
    public interface IBuff : IDisposable
    {
        
        /// <summary>
        /// 计算顺序 越小 越优先
        /// </summary>
        public int Sort { get; }
        
        /// <summary>
        /// buff 死亡时触发
        /// </summary>
        public UnityEvent OnDestroy { get; set; }
      
        public void Awake();
      
        public void Update();
        
        public void Destroy();
        
        
    }
}