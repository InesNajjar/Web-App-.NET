#pragma checksum "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33f0ef92dc2c3bd1c28a1522879524bfcc32c9cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GrowX.Pages.Pages_EventTimeline), @"mvc.1.0.razor-page", @"/Pages/EventTimeline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EventTimeline.cshtml", typeof(GrowX.Pages.Pages_EventTimeline), null)]
namespace GrowX.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Asus\Desktop\GrowXDesign\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\GrowXDesign\Pages\_ViewImports.cshtml"
using GrowX;

#line default
#line hidden
#line 3 "C:\Users\Asus\Desktop\GrowXDesign\Pages\_ViewImports.cshtml"
using GrowX.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f0ef92dc2c3bd1c28a1522879524bfcc32c9cf", @"/Pages/EventTimeline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"173d4b62638e371c4b7bdb623ec8da20a577aed9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EventTimeline : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Rechercher..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ConsulterEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-round btn-rose btn-sm pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
  
    ViewData["Title"] = "EventTimeline";

#line default
#line hidden
            BeginContext(95, 1335, true);
            WriteLiteral(@"<div class=""main-panel"">
    <!-- Navbar -->
    <nav class=""navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top "" id=""navigation-example"">
        <div class=""container-fluid"">
            <div class=""navbar-wrapper"">
                <div class=""navbar-minimize"">
                    <button id=""minimizeSidebar"" class=""btn btn-just-icon btn-white btn-fab btn-round"">
                        <i class=""material-icons text_align-center visible-on-sidebar-regular"">more_vert</i>
                        <i class=""material-icons design_bullet-list-67 visible-on-sidebar-mini"">view_list</i>
                    </button>
                </div>
                <a class=""navbar-brand"" href=""#"">Evénements</a>
            </div>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"" data-target=""#navigation-example"">
                <span class=""sr-only"">Toggle navigation</span>
    ");
            WriteLiteral(@"            <span class=""navbar-toggler-icon icon-bar""></span>
                <span class=""navbar-toggler-icon icon-bar""></span>
                <span class=""navbar-toggler-icon icon-bar""></span>
            </button>
            <div class=""collapse navbar-collapse justify-content-end"">
                ");
            EndContext();
            BeginContext(1430, 521, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a2224705b8b4aed99a6f9e863010c52", async() => {
                BeginContext(1456, 83, true);
                WriteLiteral("\r\n                    <div class=\"input-group no-border\">\r\n                        ");
                EndContext();
                BeginContext(1539, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dddde9ac02b1431ca509bc4eb538233a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 28 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1637, 307, true);
                WriteLiteral(@"
                        <button type=""submit"" class=""btn btn-white btn-round btn-just-icon"">
                            <i class=""material-icons"">search</i>
                            <div class=""ripple-container""></div>
                        </button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1951, 1889, true);
            WriteLiteral(@"
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">
                            <i class=""material-icons"">dashboard</i>
                            <p class=""d-lg-none d-md-block"">
                                Stats
                            </p>
                        </a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link"" href=""http://example.com"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">notifications</i>

                            <p class=""d-lg-none d-md-block"">
                                Some Actions
                            </p>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">

                        </div>
         ");
            WriteLiteral(@"           </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">
                            <i class=""material-icons"">person</i>
                            <p class=""d-lg-none d-md-block"">
                                Account
                            </p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class=""content"">
        <div class=""container-fluid"">
            <div class=""header text-center"">
                <h3 class=""title"">Timeline</h3>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""card card-timeline card-plain"">
                        <div class=""card-body"">
                            <ul class=""timeline"">
");
            EndContext();
#line 78 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                  
                                    var counter = 1;
                                

#line default
#line hidden
            BeginContext(3965, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                 foreach (var item in Model.EventList)
                                {
                                    counter = counter + 1;

                                    if (counter % 2 == 0)
                                    {

#line default
#line hidden
            BeginContext(4234, 232, true);
            WriteLiteral("                                        <li class=\"timeline-inverted\">\r\n\r\n\r\n                                            <div class=\"timeline-badge info\">\r\n                                                <i class=\"fa fa-check-circle\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4466, "\"", 4514, 1);
#line 92 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
WriteAttributeValue("", 4471, Model.getTypeEvent(item.IdEventType.Value), 4471, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4515, 309, true);
            WriteLiteral(@"></i>
                                            </div>

                                            <div class=""timeline-panel"">
                                                <div class=""timeline-heading"">
                                                    <span class=""badge badge-pill badge-info"">");
            EndContext();
            BeginContext(4825, 40, false);
#line 97 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(4865, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(4869, 42, false);
#line 97 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                                                                                                     Write(Model.getTypeEvent(item.IdEventType.Value));

#line default
#line hidden
            EndContext();
            BeginContext(4911, 270, true);
            WriteLiteral(@"</span>
                                                </div>
                                                <div class=""timeline-body"">
                                                    <p>
                                                        Organisé par : ");
            EndContext();
            BeginContext(5182, 44, false);
#line 101 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.Organizer));

#line default
#line hidden
            EndContext();
            BeginContext(5226, 143, true);
            WriteLiteral("\r\n                                                    </p><h6 class=\"text-bold\">\r\n                                                        Le   ");
            EndContext();
#line 103 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                               
                                                            String MyString;
                                                            MyString = item.DateEvent.Value.ToString("dd-MM-yyyy");
                                                        

#line default
#line hidden
            BeginContext(5627, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
#line 107 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                          Write(MyString);

#line default
#line hidden
            BeginContext(5704, 60, true);
            WriteLiteral("                                                        à   ");
            EndContext();
            BeginContext(5765, 43, false);
#line 108 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(5808, 328, true);
            WriteLiteral(@"
                                                    </h6>
                                                </div>
                                                <div class=""timeline-footer"">
                                                    <div class=""dropdown"">
                                                        ");
            EndContext();
            BeginContext(6136, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38cdb5b841b64aba90d8dcd46e7c2277", async() => {
                BeginContext(6240, 129, true);
                WriteLiteral("\r\n                                                            Consulter\r\n                                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                                                        WriteLiteral(item.IdE);

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
            BeginContext(6373, 217, true);
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n                                        </li>\r\n");
            EndContext();
#line 120 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(6712, 215, true);
            WriteLiteral("                                        <li class=\"\">\r\n\r\n\r\n                                            <div class=\"timeline-badge info\">\r\n                                                <i class=\"fa fa-check-circle\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6927, "\"", 6975, 1);
#line 128 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
WriteAttributeValue("", 6932, Model.getTypeEvent(item.IdEventType.Value), 6932, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6976, 309, true);
            WriteLiteral(@"></i>
                                            </div>

                                            <div class=""timeline-panel"">
                                                <div class=""timeline-heading"">
                                                    <span class=""badge badge-pill badge-info"">");
            EndContext();
            BeginContext(7286, 40, false);
#line 133 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(7326, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(7330, 42, false);
#line 133 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                                                                                                     Write(Model.getTypeEvent(item.IdEventType.Value));

#line default
#line hidden
            EndContext();
            BeginContext(7372, 270, true);
            WriteLiteral(@"</span>
                                                </div>
                                                <div class=""timeline-body"">
                                                    <p>
                                                        Organisé par : ");
            EndContext();
            BeginContext(7643, 44, false);
#line 137 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.Organizer));

#line default
#line hidden
            EndContext();
            BeginContext(7687, 143, true);
            WriteLiteral("\r\n                                                    </p><h6 class=\"text-bold\">\r\n                                                        Le   ");
            EndContext();
#line 139 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                               
                                                            String MyString;
                                                            MyString = item.DateEvent.Value.ToString("dd-MM-yyyy");
                                                        

#line default
#line hidden
            BeginContext(8088, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
#line 143 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                          Write(MyString);

#line default
#line hidden
            BeginContext(8165, 60, true);
            WriteLiteral("                                                        à   ");
            EndContext();
            BeginContext(8226, 43, false);
#line 144 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(8269, 328, true);
            WriteLiteral(@"
                                                    </h6>
                                                </div>
                                                <div class=""timeline-footer"">
                                                    <div class=""dropdown"">
                                                        ");
            EndContext();
            BeginContext(8597, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73a56703e8094dc4bc61e0ef16efd1e6", async() => {
                BeginContext(8701, 129, true);
                WriteLiteral("\r\n                                                            Consulter\r\n                                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 149 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                                                                        WriteLiteral(item.IdE);

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
            BeginContext(8834, 217, true);
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n                                        </li>\r\n");
            EndContext();
#line 156 "C:\Users\Asus\Desktop\GrowXDesign\Pages\EventTimeline.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(9125, 117, true);
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n\r\n                    ");
            EndContext();
            BeginContext(9242, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca8e1675db54a74b313c1703bbe4f8d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9290, 646, true);
            WriteLiteral(@"
                    <script>
                        var result = $(""#Project Success"").val();
                        if (result = ""New Client"") {
                            document.getElementById(""New Client"").className = ""fa fa-user bg-aqua"";
                            document.getElementById(""Birthday"").className = ""fa fa-birthday-cake bg-yellow"";
                        }
                        else {
                            document.className = ""fa fa-birthday-cake bg-yellow"";
                        }
                    </script>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrowX.Pages.EventTimelineModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GrowX.Pages.EventTimelineModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GrowX.Pages.EventTimelineModel>)PageContext?.ViewData;
        public GrowX.Pages.EventTimelineModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591