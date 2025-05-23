using Resources;


namespace Movement
{
    public interface IMovePerformer
    {
        public void PerformMovement();
        public void Stop();

        public PlayerState State { get; }
        public bool IsPlaying { get; }
    }
}