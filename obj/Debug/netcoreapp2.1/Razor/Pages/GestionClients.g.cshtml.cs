#pragma checksum "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2922b496ac6baf7e7105a85a14ff18c18b6589ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GrowX.Pages.Pages_GestionClients), @"mvc.1.0.razor-page", @"/Pages/GestionClients.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/GestionClients.cshtml", typeof(GrowX.Pages.Pages_GestionClients), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2922b496ac6baf7e7105a85a14ff18c18b6589ab", @"/Pages/GestionClients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"173d4b62638e371c4b7bdb623ec8da20a577aed9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GestionClients : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Rechercher..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ModifierClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Voulez-vous vraiment modifier ce client?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./GestionClients", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Voulez-vous vraiment supprimer ce client?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ConsulterClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
  
    ViewData["Title"] = "GestionClients";

#line default
#line hidden
            BeginContext(97, 1428, true);
            WriteLiteral(@"    <div class=""main-panel"">
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
                    <a class=""navbar-brand"" href=""#"">Clients | Prospects</a>
                </div>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"" data-target=""#navigation-example"">
   ");
            WriteLiteral(@"                 <span class=""sr-only"">Toggle navigation</span>
                    <span class=""navbar-toggler-icon icon-bar""></span>
                    <span class=""navbar-toggler-icon icon-bar""></span>
                    <span class=""navbar-toggler-icon icon-bar""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-end"">
                    ");
            EndContext();
            BeginContext(1525, 553, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38fb5e3da5724a0da5efcf70532a5e0c", async() => {
                BeginContext(1551, 91, true);
                WriteLiteral("\r\n                        <div class=\"input-group no-border\">\r\n                            ");
                EndContext();
                BeginContext(1642, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01b661ee57774748bd4609a23d7ff128", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 28 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
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
                BeginContext(1740, 331, true);
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
            BeginContext(2078, 4351, true);
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
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""n");
            WriteLiteral(@"avbarDropdownMenuLink"">

                            </div>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#pablo"">
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
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""card"">
                            <div class=""card-header card-header-primary card-header-icon"">
                                <div class=""card-icon"">
                                    <i class=""material-icons"">assignment</i>
                       ");
            WriteLiteral(@"         </div>
                                <h4 class=""card-title"">Table de Gestion Clients/Prospects</h4>
                            </div>
                            <div class=""card-body"">
                                <div class=""toolbar"">
                                    <!--        Here you can write extra buttons/actions for the toolbar              -->
                                </div>
                                <div class=""material-datatables"">
                                    <table id=""datatables"" class=""table table-striped table-no-bordered table-hover"" cellspacing=""0"" width=""100%"" style=""width:100%"">
                                        <thead>
                                            <tr>
                                                <th>
                                                    Nom
                                                </th>
                                                <th>
                                                   ");
            WriteLiteral(@" Domaine
                                                </th>
                                                <th>
                                                    N° de téléphone
                                                </th>
                                                <th>
                                                    E-mail
                                                </th>
                                                <th>
                                                    Localisation
                                                </th>
                                                <th>
                                                    Type
                                                </th>
                                                <th>
                                                    Image
                                                </th>
                                                <th>Modifier</th>
                                   ");
            WriteLiteral("             <th>Supprimer</th>\r\n                                                <th>Consulter</th>\r\n\r\n                                            </tr>\r\n                                        </thead>\r\n\r\n                                        <tbody>\r\n");
            EndContext();
#line 116 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                             foreach (var item in Model.ClientList)
                                            {

#line default
#line hidden
            BeginContext(6561, 168, true);
            WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(6730, 39, false);
#line 120 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(6769, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(6945, 41, false);
#line 123 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Domain));

#line default
#line hidden
            EndContext();
            BeginContext(6986, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(7162, 46, false);
#line 126 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(7208, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(7384, 39, false);
#line 129 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Mail));

#line default
#line hidden
            EndContext();
            BeginContext(7423, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(7599, 50, false);
#line 132 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.LocationAddress));

#line default
#line hidden
            EndContext();
            BeginContext(7649, 61, true);
            WriteLiteral("\r\n                                                    </td>\r\n");
            EndContext();
#line 134 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                     if (item.Category == "Prospect")
                                                    {

#line default
#line hidden
            BeginContext(7852, 142, true);
            WriteLiteral("                                                        <td class=\"text-danger\">\r\n                                                            ");
            EndContext();
            BeginContext(7995, 43, false);
#line 137 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
            EndContext();
            BeginContext(8038, 65, true);
            WriteLiteral("\r\n                                                        </td>\r\n");
            EndContext();
#line 139 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(8271, 146, true);
            WriteLiteral("                                                        <td class=\"text-light-blue\">\r\n                                                            ");
            EndContext();
            BeginContext(8418, 43, false);
#line 143 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
            EndContext();
            BeginContext(8461, 65, true);
            WriteLiteral("\r\n                                                        </td>\r\n");
            EndContext();
#line 145 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(8581, 116, true);
            WriteLiteral("\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(8697, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8fdc889857074abfbc640ff90e37b6fd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#line 148 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                                            WriteLiteral(item.ImagePath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 149 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 149 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
AddHtmlAttributeValue("", 8839, item.ImagePath, 8839, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8886, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(9061, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86edc2f11e9942438ff4f6045ed1530c", async() => {
                BeginContext(9187, 8, true);
                WriteLiteral("Modifier");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 152 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                                                                                                                               WriteLiteral(item.IdC);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9199, 177, true);
            WriteLiteral("\r\n\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(9376, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cef79db58f4430e8a80a4c433ef587f", async() => {
                BeginContext(9529, 9, true);
                WriteLiteral("Supprimer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 156 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                                                                                                                                                          WriteLiteral(item.IdC);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9542, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(9717, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "845bb6757adf47dc8e40552813cc88e8", async() => {
                BeginContext(9773, 9, true);
                WriteLiteral("Consulter");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 159 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                                                                         WriteLiteral(item.IdC);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9786, 116, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
            EndContext();
#line 162 "C:\Users\Asus\Desktop\GrowXDesign\Pages\GestionClients.cshtml"
                                            }

#line default
#line hidden
            BeginContext(9949, 482, true);
            WriteLiteral(@"
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <!-- end content-->
                        </div>
                        <!--  end card  -->
                    </div>
                    <!-- end col-md-12 -->
                </div>
                <!-- end row -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrowX.Pages.GestionClientsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GrowX.Pages.GestionClientsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GrowX.Pages.GestionClientsModel>)PageContext?.ViewData;
        public GrowX.Pages.GestionClientsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591