
namespace Combat.Runtime
{
    /// <summary>
    /// 增益
    /// </summary>
    public class Buff : IBuff
    {
        public event IBuff.OnDestroy destroy;

        public virtual int Order
        {
            get => 0;
        }

        public virtual E_Buff_Type BuffType => E_Buff_Type.Buff;

        public virtual void Start()
        {
            
        }
        
        public virtual object Calculate(object obj)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update(float deltaTime)
        {
            
        }

        public virtual void Destroy()
        {
            destroy?.Invoke();
        }

        public virtual void Dispose()
        {
            
        }
    }
}