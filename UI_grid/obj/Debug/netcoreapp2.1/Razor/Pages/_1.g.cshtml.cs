#pragma checksum "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62a6a242e2d271c278aa49a9116f5f511744387"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UI_grid.Pages.Pages__1), @"mvc.1.0.razor-page", @"/Pages/_1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/_1.cshtml", typeof(UI_grid.Pages.Pages__1), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62a6a242e2d271c278aa49a9116f5f511744387", @"/Pages/_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2f2e0ff53d0b122217bf27d3bece029a1b00c7", @"/Pages/_ViewImports.cshtml")]
    public class Pages__1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
  
    ViewData["Title"] = "Question #1";

#line default
#line hidden
            BeginContext(642, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(646, 1074, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08827cac92a44c368a82e10708c1cd46", async() => {
                BeginContext(652, 27, true);
                WriteLiteral("\r\n\r\n<h2>1</h2>\r\n\r\n<p>\r\n    ");
                EndContext();
                BeginContext(680, 22, false);
#line 23 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
Write(Model.Question.Content);

#line default
#line hidden
                EndContext();
                BeginContext(702, 12, true);
                WriteLiteral("\r\n\r\n</p>\r\n\r\n");
                EndContext();
                BeginContext(714, 997, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1dccbbb24f04b30a916ec0f954a9ad3", async() => {
                    BeginContext(734, 15, true);
                    WriteLiteral("\r\n    <table>\r\n");
                    EndContext();
#line 29 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
         for (int i = 0; i < Model.Answers.Count; i++)
        {

#line default
#line hidden
                    BeginContext(816, 60, true);
                    WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                    EndContext();
                    BeginContext(877, 24, false);
#line 33 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
               Write(Model.Answers[i].Content);

#line default
#line hidden
                    EndContext();
                    BeginContext(901, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(902, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46dc8bc2919c4a739faacd7999440c8a", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 33 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
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
                    BeginContext(940, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 34 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
                     if (Model.Messages != null)
                    {
                        if (Model.Messages[i].Equals("Correct"))
                        {

#line default
#line hidden
                    BeginContext(1108, 55, true);
                    WriteLiteral("                            <span style=\"color: green\">");
                    EndContext();
                    BeginContext(1164, 17, false);
#line 38 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
                                                  Write(Model.Messages[i]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1181, 10, true);
                    WriteLiteral(" </span>\r\n");
                    EndContext();
#line 39 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                    BeginContext(1275, 53, true);
                    WriteLiteral("                            <span style=\"color: red\">");
                    EndContext();
                    BeginContext(1329, 17, false);
#line 42 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
                                                Write(Model.Messages[i]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1346, 10, true);
                    WriteLiteral(" </span>\r\n");
                    EndContext();
#line 43 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
                        }
                    }

#line default
#line hidden
                    BeginContext(1406, 54, true);
                    WriteLiteral("                </td>\r\n            </tr>\r\n            ");
                    EndContext();
                    BeginContext(1460, 76, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3e50b3e406d4dd0803a0c89b5139fac", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 47 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Answers[i].Id);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
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
                    BeginContext(1536, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 48 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_1.cshtml"
        }

#line default
#line hidden
                    BeginContext(1549, 155, true);
                    WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                <input id=\"Submit1\" type=\"submit\" value=\"submit\" />\r\n            </td>\r\n\r\n        </tr>\r\n\r\n    </table>\r\n");
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
                BeginContext(1711, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1720, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UI_grid.Pages._1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UI_grid.Pages._1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UI_grid.Pages._1Model>)PageContext?.ViewData;
        public UI_grid.Pages._1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
