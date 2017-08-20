using System;
namespace Babosik.Web.Helpers
{
    public static class ControllerHelper
    {
        const string Suffix = "Controller";

        public static string GetNoSuffixName(string originalName)
        {
            var suffixLength = Suffix.Length;
            var originalNameLength = originalName.Length;
            var noSuffixName = originalName.Substring(0, originalNameLength - suffixLength);

            return noSuffixName;
        }
    }
}
