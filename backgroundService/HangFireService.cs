namespace MvcApp1.backgroundService
{
    public class HangFireService : IHangFireService
    {
        public void ContinuationJob()
        {
            throw new Exception();
        }

        public void DelayedJob()
        {
            Console.WriteLine("DelayedJob");
        }

        public void Reccuringjob()
        {
            Console.WriteLine("Reccuringjob");
        }
    }
}