namespace InterServ.service
{
    public class Getting : IService
    {
         public string DisplayMsg(string name)
        {
            return $"Hello {name}";
        }
    }
}
