#pragma checksum "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f996a761c04dbcd6f8068001e37aec27d9b32c97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UI_grid.Pages.Pages_53), @"mvc.1.0.razor-page", @"/Pages/53.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/53.cshtml", typeof(UI_grid.Pages.Pages_53), null)]
namespace UI_grid.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_ViewImports.cshtml"
using UI_grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f996a761c04dbcd6f8068001e37aec27d9b32c97", @"/Pages/53.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2f2e0ff53d0b122217bf27d3bece029a1b00c7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_53 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
  
    ViewData["Title"] = "53";

#line default
#line hidden
            BeginContext(66, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(71, 17, false);
#line 6 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(107, 22, false);
#line 9 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
Write(Model.Question.Content);

#line default
#line hidden
            EndContext();
            BeginContext(129, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(139, 982, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb96667e9ef42c0aabef9c7819e9c5d", async() => {
                BeginContext(159, 15, true);
                WriteLiteral("\r\n    <table>\r\n");
                EndContext();
#line 14 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
         for (int i = 0; i < Model.Answers.Count; i++)
        {

#line default
#line hidden
                BeginContext(241, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(302, 24, false);
#line 18 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
               Write(Model.Answers[i].Content);

#line default
#line hidden
                EndContext();
                BeginContext(326, 3, true);
                WriteLiteral("   ");
                EndContext();
                BeginContext(329, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a407f8fb67e8410ab4063bad403c29f6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 18 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Answers[i].Correct);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(367, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
                     if (Model.Messages != null)
                    {
                        if (Model.Messages[i].Equals("Correct"))
                        {

#line default
#line hidden
                BeginContext(535, 55, true);
                WriteLiteral("                            <span style=\"color: green\">");
                EndContext();
                BeginContext(591, 17, false);
#line 23 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
                                                  Write(Model.Messages[i]);

#line default
#line hidden
                EndContext();
                BeginContext(608, 10, true);
                WriteLiteral(" </span>\r\n");
                EndContext();
#line 24 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(702, 53, true);
                WriteLiteral("                            <span style=\"color: red\">");
                EndContext();
                BeginContext(756, 17, false);
#line 27 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
                                                Write(Model.Messages[i]);

#line default
#line hidden
                EndContext();
                BeginContext(773, 10, true);
                WriteLiteral(" </span>\r\n");
                EndContext();
#line 28 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(833, 56, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            ");
                EndContext();
                BeginContext(889, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3402d3745c44d85bc8756ef13250738", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 33 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Answers[i].Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
                                                    WriteLiteral(Model.Answers[i].Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(965, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\53.cshtml"
        }

#line default
#line hidden
                BeginContext(978, 136, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"submit\" value=\"submit\" />\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
