#pragma checksum "E:\Business_Programming_Project\Project\Project\Pages\information_suit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9706121f71fdc556c0ae528793ccef3cd25b645c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.Pages.Pages_information_suit), @"mvc.1.0.razor-page", @"/Pages/information_suit.cshtml")]
namespace Project.Pages
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
#line 1 "E:\Business_Programming_Project\Project\Project\Pages\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9706121f71fdc556c0ae528793ccef3cd25b645c", @"/Pages/information_suit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7dae7ff6714ef70766776d91b193080525975d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_information_suit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("user_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("./information_suit_Sql"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9706121f71fdc556c0ae528793ccef3cd25b645c4499", async() => {
                WriteLiteral("\r\n    <font style=\"font-size:30px; \">\r\n        <span class=\"text-warning\" style=\"font-size: 75%\">\r\n            Please input information\r\n        </span>\r\n    </font>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9706121f71fdc556c0ae528793ccef3cd25b645c4946", async() => {
                    WriteLiteral("\r\n        ");
#nullable restore
#line 11 "E:\Business_Programming_Project\Project\Project\Pages\information_suit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"

        <div class=""form-group row"">
            <div class=""col-xl-10"">
                <span class=""text-light""> Name - Lastname</span>
                <input type=""text"" id=""name_lastName"" name=""name_lastName"" class=""form-control""
                       required>
            </div><br />
            <div class=""col-xl-4"">
                <br />
                <span class=""text-light""> ID Card - Number</span>
                <input type=""text"" id=""idcard"" name=""idcard"" class=""form-control""
                       required>
            </div><br />
            <div class=""col-xl-4"">
                <br />
                <span class=""text-light"">Phone - number</span>
                <input type=""text"" id=""phone_number"" name=""phone_number"" class=""form-control""
                       required>
            </div><br />
            <div class=""col-xl-10"">
                <br />
                <span class=""text-light""> Address</span>
                <input type=""text"" id=""address_user"" n");
                    WriteLiteral(@"ame=""address_user"" class=""form-control""
                       required>
            </div><br />
            <div class=""col-xl-4"">
                <br />
                <span class=""text-light"">Blood Type</span>
                <input type=""text"" id=""blood_type"" name=""blood_type"" class=""form-control""
                       required>
            </div><br />
            <div class=""col-xl-4"">
                <br />
                <span class=""text-light"">
                    Congenital disease
                </span>
                <input type=""text"" id=""congenital_disease"" name=""congenital_disease"" class=""form-control""
                       required>
            </div><br /><br />
            <div class=""col-xl-5"">
                <br />
                <span class=""text-light"">
                    Booking date
                </span>
                <input type=""date"" id=""booking_date"" name=""booking_date"" class=""form-control""
                       min=""1997-01-01"" max=""2030-12-3");
                    WriteLiteral(@"1"" required>
            </div><br />
        </div>
        <div style=""float: right;"">
            <div style=""float: right;"">
                <table width=""90%"" height=""75%"">
                    <tr>
                        <td></td>
                        <td>
                            <input class=""btn btn-primary btn-lg"" type=""submit"" value=""Booking"" style=""font-size: 20px;"">
                        </td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td onclick=""location.href='Home'"">
                            <input class=""btn btn-danger btn-lg"" type=""submit"" formaction=""/Home"" value=""Back"" style=""font-size: 20px;"">
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Pages.information_suitModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Pages.information_suitModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Pages.information_suitModel>)PageContext?.ViewData;
        public Project.Pages.information_suitModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591