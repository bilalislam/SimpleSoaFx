using System.Web.Mvc;

namespace GIAF.UI.Areas.InboxTurkey
{
    public class InboxTurkeyAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "InboxTurkey";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "InboxTurkey_default",
                "InboxTurkey/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
