using Resources;


namespace Invokers
{
    public class FailInvoker : MoveInputInvoker
    {
        protected override void SetupPlayerState()
        {
            _newPlayerState = PlayerState.Fail;
        }
    }
}