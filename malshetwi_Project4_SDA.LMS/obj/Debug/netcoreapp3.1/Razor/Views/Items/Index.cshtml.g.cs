#pragma checksum "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e84bb085e0d79287359c225405eb01206a2fb1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\_ViewImports.cshtml"
using malshetwi_Project4_SDA.LMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\_ViewImports.cshtml"
using malshetwi_Project4_SDA.LMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e84bb085e0d79287359c225405eb01206a2fb1a", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798ffd2e0b12ad2c19d403133dc565681ff7bf09", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn alert-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
  
    ViewData["Title"] = "M Sh Pizza";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-offset-1 "">

        <table class=""table"">
            <thead>
                <tr>
                    <th>Pizza Pic</th>
                    <th>Name</th>
                    <th>Details</th>
                    <th>Price</th>
                    
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
                 foreach (var Item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e84bb085e0d79287359c225405eb01206a2fb1a5753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 606, "~/Images/Pizzas/", 606, 16, true);
#nullable restore
#line 25 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
AddHtmlAttributeValue("", 622, Item.ItemPicURL, 622, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 640, ".png", 640, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
AddHtmlAttributeValue("", 651, Item.ItemName, 651, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => Item.ItemName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => Item.ItemBio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => Item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>SR</p></td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e84bb085e0d79287359c225405eb01206a2fb1a9070", async() => {
                WriteLiteral("Order +");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
                                                                             WriteLiteral(Item.ItemID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                        <!--<a class=\"btn alert-warning\" asp-action=\"Edit\" asp-route-id=\"");
#nullable restore
#line 32 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"
                                                                                    Write(Item.ItemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a>-->\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\msh32\source\repos\SDA_Simplilearn\Phase4_SDA\Project4\malshetwi_Project4_SDA.LMS\Views\Items\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591