#pragma checksum "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcd5167c08315e7d31de3efad34bf66b05c65f26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Edit), @"mvc.1.0.view", @"/Views/Task/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Edit.cshtml", typeof(AspNetCore.Views_Task_Edit))]
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
#line 1 "/home/daiane/Documentos/Projetos/ToDoList/Views/_ViewImports.cshtml"
using ToDoList;

#line default
#line hidden
#line 2 "/home/daiane/Documentos/Projetos/ToDoList/Views/_ViewImports.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcd5167c08315e7d31de3efad34bf66b05c65f26", @"/Views/Task/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57829472ded1cf7bde1d515ed88d0e9bc5d97088", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Task>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 35, true);
            WriteLiteral("\n<div class=\"form-horizontal\">\n    ");
            EndContext();
            BeginContext(64, 922, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcd5167c08315e7d31de3efad34bf66b05c65f263901", async() => {
                BeginContext(98, 40, true);
                WriteLiteral("\n\n        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 138, "\"", 155, 1);
#line 6 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Edit.cshtml"
WriteAttributeValue("", 146, Model.id, 146, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(156, 136, true);
                WriteLiteral("/>   \n\n        <div class=\"form-group\">\n            <label>Name</label>\n            <input  class=\"form-control\" type=\"text\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 292, "\"", 311, 1);
#line 10 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Edit.cshtml"
WriteAttributeValue("", 300, Model.name, 300, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(312, 156, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Priority</label>\n            <input  class=\"form-control\" type=\"text\" name=\"priority\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 468, "\"", 491, 1);
#line 15 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Edit.cshtml"
WriteAttributeValue("", 476, Model.priority, 476, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(492, 156, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Deadline</label>\n            <input  class=\"form-control\" type=\"text\" name=\"deadline\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 648, "\"", 671, 1);
#line 20 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Edit.cshtml"
WriteAttributeValue("", 656, Model.deadline, 656, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(672, 179, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Percentage Completed</label>\n            <input  class=\"form-control\" type=\"text\" name=\"percentageCompleted\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 851, "\"", 885, 1);
#line 25 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Edit.cshtml"
WriteAttributeValue("", 859, Model.percentageCompleted, 859, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(886, 93, true);
                WriteLiteral("/>\n        </div>\n\n        <input  class=\"btn btn-primary\" type=\"submit\" value=\"Save\"/>\n\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(986, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Task> Html { get; private set; }
    }
}
#pragma warning restore 1591