namespace MvcApp1.backgroundService
{
    public interface IHangFireService
    {
        void DelayedJob();
        void Reccuringjob();
        void ContinuationJob();
    }
}