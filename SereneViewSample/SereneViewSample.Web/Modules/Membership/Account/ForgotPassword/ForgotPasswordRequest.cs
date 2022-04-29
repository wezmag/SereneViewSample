using Serenity.ComponentModel;
using Serenity.Services;
using System;
using System.ComponentModel;

namespace SereneViewSample.Membership
{
    [FormScript("Membership.ForgotPassword")]
    public class ForgotPasswordRequest : ServiceRequest
    {
        [Required(true), EmailAddressEditor, DisplayName("E-mail Address")]
        public String Email { get; set; }
    }
}