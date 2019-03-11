# Graph Umbraco Components - Cookie Banner

Install Nuget packages:
* `Install-Package UmbracoMapper`
* `Install-Package UCreate`
* `Install-Package HtmlTransformation`

## Installation steps:
1. Install Nuget packages
2. Copy all files to the folder 'CookieBanner' in ~\App_Plugins\
3. Use it: @Html.Action("Index", "CookieBannerSurface")

## Settings
The only mandatory field in settings is "CookieBannerSettingsId" - id of the Settings node with all needed fields