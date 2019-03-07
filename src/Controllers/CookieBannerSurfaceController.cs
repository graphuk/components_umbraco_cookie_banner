using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Zone.UmbracoMapper;

namespace Graph.Components.CookieBanner
{
	public class CookieBannerSurfaceController : SurfaceController
	{
		private readonly IUmbracoMapper _mapper;

		public CookieBannerSurfaceController(IUmbracoMapper mapper)
		{
			_mapper = mapper;
		}

		public ActionResult Index()
		{
			var settings = new UmbracoHelper(UmbracoContext.Current)
				.TypedContent(CookieBannerConfig.CookieBannerSettingsId);

			var cookieBannerModel = new CookieBannerModel();
			_mapper.Map(settings, cookieBannerModel);

			return View("/App_Plugins/CookieBanner/Views/CookieBanner.cshtml", cookieBannerModel);
		}
	}
}
