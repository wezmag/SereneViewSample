using Serenity.Services;

namespace SereneViewSample.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}