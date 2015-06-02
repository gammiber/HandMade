using System.Web.Mvc;

namespace HM.Areas.ArtisanList
{
    public class ArtisanListAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ArtisanList";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ArtisanList_default",
                "ArtisanList/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}