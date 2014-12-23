using NDesk.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win8Toast;

namespace console_toast_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string template = "", title = "", line1 = "", line2 = "", img = "", icon = "", app_id = "console-toast-8";
            bool silent = false;

            OptionSet p = new OptionSet()
                .Add("template=",   "toast template",                                   x => template = x)
                .Add("title=",      "toast tile",                                       x => title = EnsureStringUsesUTF8(x))
                .Add("line1=",      "line one text (all templates)",                    x => line1 = EnsureStringUsesUTF8(x))
                .Add("line2=",      "line two text (Text/Text&Image04 templates)",      x => line2 = EnsureStringUsesUTF8(x))
                .Add("img=",        "img url (local or external, all img templates)",   x => img = x)
                .Add("app_id=",     "name to appear in start menu (optional)",          x => app_id = x)
                .Add("icon=",       "path to .ico (optional)",                          x => icon = x)
                .Add("silent",      "prevent default notification noise (optional)",    x => silent = x != null);

            p.Parse(args);

            if (args.Length == 0 || template == "")
                Environment.Exit(1);

            Toast.APP_ID = app_id;
            Toast.silent = silent;
            Toast.ICON_LOCATION = icon;
            Toast.TryCreateShortcut();

            switch (template)
            {
                case "ToastImageAndText01":
                    Toast.ToastToastImageAndText01(line1, img);
                    break;
                case "ToastImageAndText02":
                    Toast.ToastToastImageAndText02(title, line1, img);
                    break;
                case "ToastImageAndText03":
                    Toast.ToastToastImageAndText03(title, line1, img);
                    break;
                case "ToastImageAndText04":
                    Toast.ToastToastImageAndText04(title, line1, line2, img);
                    break;
                case "ToastText01":
                    Toast.ToastToastText01(line1);
                    break;
                case "ToastText02":
                    Toast.ToastToastText02(title, line1);
                    break;
                case "ToastText03":
                    Toast.ToastToastText03(title, line1);
                    break;
                case "ToastText04":
                    Toast.ToastToastText04(title, line1, line2);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }

            Environment.Exit(0);
        }

        static String EnsureStringUsesUTF8(String str)
        {
            if (str != null && str.Length > 0)
                return Encoding.UTF8.GetString(Encoding.Default.GetBytes(str));
            else
                return str;
        }
    }
}
