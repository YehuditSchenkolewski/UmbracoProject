namespace MyProject.Interfaces
{
    public interface IMangUserService
    {
        Task<bool> ResaetPassword(string mail, string password);
    }
}
