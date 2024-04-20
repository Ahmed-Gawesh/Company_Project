using Project.DAL.Models;

namespace Project.PL.Helpers
{
    public interface IEmailSettings
    {
        public void SendEmail(Email email);
    }
}
