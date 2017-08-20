using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Babosik.Web.Controllers;
using static Babosik.Web.Helpers.ControllerHelper;

namespace Microsoft.AspNetCore.Mvc
{
    public static class UrlHelperExtensions
    {
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(UserAccountController.ConfirmEmail),
                controller: GetNoSuffixName(nameof(UserAccountController)),
                values: new { userId, code },
                protocol: scheme);
        }

        public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(UserAccountController.ResetPassword),
                controller: GetNoSuffixName(nameof(UserAccountController)),
                values: new { userId, code },
                protocol: scheme);
        }
    }
}
