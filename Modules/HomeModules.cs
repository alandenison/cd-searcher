using Nancy;
using System.Collections.Generic;
using CDOrganizer.Objects;

namespace CDOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var allCDs = CD.GetAllCDs();
        return View["index.cshtml", allCDs];
      };
      Get["/cd/new"] = _ => {
        return View["add_cd_form.cshtml"];
      };
      Post["/"] = _ => {
        var newCD = new CD(Request.Form["cd-name"], Request.Form["artist-name"]);
        var allCDs = CD.GetAllCDs();
        return View["index.cshtml", allCDs];
      };
    }
  }
}
