#pragma checksum "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d4e3067218d6c3fed25347e88138e26ff4f2afb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OlxBg.Pages.Advertisements.Pages_Advertisements_Search), @"mvc.1.0.razor-page", @"/Pages/Advertisements/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Advertisements/Search.cshtml", typeof(OlxBg.Pages.Advertisements.Pages_Advertisements_Search), null)]
namespace OlxBg.Pages.Advertisements
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\_ViewImports.cshtml"
using OlxBg;

#line default
#line hidden
#line 3 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\_ViewImports.cshtml"
using OlxBg.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d4e3067218d6c3fed25347e88138e26ff4f2afb", @"/Pages/Advertisements/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57e7cba90e6123725232a1c0a8c1c075a9ca7824", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Advertisements_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fleft"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100% !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("marginright5 link linkWithHash detailsLink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
  
    ViewData["Title"] = @SearchModel.SearchWords;

#line default
#line hidden
            BeginContext(85, 247, true);
            WriteLiteral("<style>\r\n    .searchmain {\r\n        margin-bottom: 20px;\r\n    }\r\n    .maincategories {\r\n        display:none;\r\n    }\r\n</style>\r\n<section class=\"mainpage-gallery clr\" id=\"mainpageAds\">\r\n\r\n    <header style=\"margin-top:20px;\">\r\n        <h3>Намерени ");
            EndContext();
            BeginContext(333, 17, false);
#line 17 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                Write(SearchModel.Count);

#line default
#line hidden
            EndContext();
            BeginContext(350, 42, true);
            WriteLiteral(" обяви</h3>\r\n        <p>Безплатни обяви - ");
            EndContext();
            BeginContext(393, 23, false);
#line 18 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                        Write(SearchModel.SearchWords);

#line default
#line hidden
            EndContext();
            BeginContext(416, 58, true);
            WriteLiteral("  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   Населено място - ");
            EndContext();
            BeginContext(475, 20, false);
#line 18 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                                                                                                          Write(SearchModel.CityName);

#line default
#line hidden
            EndContext();
            BeginContext(495, 126, true);
            WriteLiteral("</p>\r\n    </header>\r\n    <hr style=\"margin-top:-10px;\"/>\r\n    <ul class=\"gallerywide clr normal\" id=\"gallerywide\">\r\n        \r\n");
            EndContext();
            BeginContext(1398, 212, true);
            WriteLiteral("        \r\n\r\n\r\n\r\n\r\n            <table width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" id=\"offers_table\" class=\"fixed offers breakword redesigned\" summary=\"Обяви\">\r\n                <tbody>\r\n                    </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                     if(SearchModel.Count==0)
                    {

#line default
#line hidden
            BeginContext(1680, 115, true);
            WriteLiteral("                        <p style=\"text-align:center;font-size:15px;line-height:50px;\">Няма намерени резултати</p>\r\n");
            EndContext();
#line 45 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                    }

#line default
#line hidden
            BeginContext(1818, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 46 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                     foreach (var item in Model.Advert)
                    {


#line default
#line hidden
            BeginContext(1900, 583, true);
            WriteLiteral(@"                        <tr class=""wrap"" rel="""">
                            <td class=""offer  "">
                                <div class=""offer-wrapper"">
                                    <table width=""100%"" cellspacing=""0"" cellpadding=""0"" class=""fixed breakword  ad_id7AcEl"" summary=""Oбява"" data-id=""112062789"">
                                        <tbody>
                                            <tr>
                                                <td width=""150"" rowspan=""2"" style=""background:whitesmoke;"">
                                                    ");
            EndContext();
            BeginContext(2483, 314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5b58947c65d400c8c67f8b9f581bb98", async() => {
                BeginContext(2581, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(2639, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48228f09cc0f40458d18bdf696703643", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2663, "~/uploads/", 2663, 10, true);
#line 57 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
AddHtmlAttributeValue("", 2673, Html.DisplayFor(modelItem => item.ImageName), 2673, 45, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2739, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                                                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2797, 371, true);
            WriteLiteral(@"
                                                </td>
                                                <td valign=""top"" class=""title-cell"">
                                                    <div class=""space rel"">
                                                        <h3 class=""lheight22 margintop5"">
                                                            ");
            EndContext();
            BeginContext(3168, 289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "519b49bccd3a4246a296e0a933bc0d11", async() => {
                BeginContext(3267, 74, true);
                WriteLiteral("\r\n                                                                <strong>");
                EndContext();
                BeginContext(3342, 40, false);
#line 64 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(3382, 71, true);
                WriteLiteral("</strong>\r\n                                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                                                                                      WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3457, 326, true);
            WriteLiteral(@"
                                                        </h3>

                                                        <p class=""color-9 lheight16 margintop5"">
                                                            <small class=""breadcrumb x-normal"">
                                                                ");
            EndContext();
            BeginContext(3784, 38, false);
#line 70 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Cat));

#line default
#line hidden
            EndContext();
            BeginContext(3822, 626, true);
            WriteLiteral(@"
                                                            </small>
                                                        </p>
                                                    </div>
                                                </td>
                                                <td width=""200"" class=""wwnormal tright td-price"" valign=""top"">
                                                    <div class=""space inlblk rel"">
                                                        <p class=""price"" style=""overflow: visible !important;"">
                                                            <strong>");
            EndContext();
            BeginContext(4449, 40, false);
#line 78 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(4489, 881, true);
            WriteLiteral(@" лв.</strong>
                                                        </p>
                                                    </div>

                                                </td>
                                            </tr>
                                            <tr>
                                                <td valign=""bottom"" class=""bottom-cell"">
                                                    <div class=""space rel"">
                                                        <p class=""lheight16"">
                                                            <small class=""breadcrumb x-normal"" style=""margin-bottom: -20px !important;margin-top:10px !important;"">
                                                                <span>
                                                                    <i data-icon=""location-filled""></i>");
            EndContext();
            BeginContext(5371, 42, false);
#line 90 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                                                                                                  Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(5413, 577, true);
            WriteLiteral(@"
                                                                </span>
                                                            </small>
                                                        </p>
                                                    </div>
                                                </td>
                                            </tr>

                                        </tbody>
                                    </table>
                                </div>
                            </td>
                        </tr>
");
            EndContext();
#line 103 "C:\Users\Djem\source\repos\OlxBg\OlxBg\Pages\Advertisements\Search.cshtml"
                    }

#line default
#line hidden
            BeginContext(6013, 81, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                    </tbody>\r\n            </table>\r\n    </ul>\r\n</section>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchModel>)PageContext?.ViewData;
        public SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
