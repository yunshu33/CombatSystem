using System;

namespace Combat.Runtime
{
    public interface IBuff : IDisposable
    {
        public delegate void OnDestroy();

        public event OnDestroy destroy;
        
        /// <summary>
        /// 计算顺序 越小 越优先
        /// </summary>
        public int Order { get; }

        public E_Buff_Type BuffType { get; }

        public void Start();
      
        public void Update(float deltaTime);

        /// <summary>
        /// 计算
        /// </summary>
        public object Calculate(object obj);
        
        /// <summary>
        /// 结束时触发
        /// </summary>
        public void Destroy();
        
        
    }

    public enum E_Buff_Type
    {
        None,
        Buff,
        Debuff
    }
}