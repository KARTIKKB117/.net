namespace Deplnj.Services
{
    public class MyService : IMyService
    {

        public string GetMessage()
        {
            return "Hello from MYService using Dependency Injection  ";
        }
    }
}
