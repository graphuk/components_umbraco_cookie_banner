using NicBell.UCreate.Attributes;
using NicBell.UCreate.Constants;

namespace Graph.Components.CookieBanner
{
	[DocType(Name = "Cookie Banner Settings", Icon = "icon-settings", AllowedAsRoot = true)]
	public class CookieBannerSettings
	{
		[Property(TypeName = PropertyTypes.Richtexteditor, Name = "Message", TabName = "Content", Alias = CookieBannerConfig.MessageFieldAlias)]
		public string Message { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "Ok Button", TabName = "Content", Alias = CookieBannerConfig.OkButtonFieldAlias)]
		public string OkButton { get; set; }
	}
}
