#pragma checksum "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f505743114c1f9205952c44ed4a011b013796be0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Index.cshtml", typeof(AspNetCore.Views_Task_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f505743114c1f9205952c44ed4a011b013796be0", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57829472ded1cf7bde1d515ed88d0e9bc5d97088", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDoList.Models.Task>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 589, true);
            WriteLiteral(@"
<br></br>
<a href=""Task/Create"" class=""btn btn-primary""> New Task </a>
<a href=""Task/ViewCompletedTasks"" class=""btn btn-primary""> View Completed Tasks </a>
<br></br>

<div class=""container"">
    <fieldset>
        <legend>
            <label>List of Tasks</label>
        </legend>

        <table class=""table"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Priority</th>
                    <th>Deadline</th>
                    <th>Percentage Completed</th>
                    <th></th>
                </tr>
            </thead>

");
            EndContext();
#line 25 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(685, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(731, 9, false);
#line 28 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Index.cshtml"
                   Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(740, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(771, 13, false);
#line 29 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Index.cshtml"
                   Write(item.priority);

#line default
#line hidden
            EndContext();
            BeginContext(784, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(815, 13, false);
#line 30 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Index.cshtml"
                   Write(item.deadline);

#line default
#line hidden
            EndContext();
            BeginContext(828, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(859, 24, false);
#line 31 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Index.cshtml"
                   Write(item.percentageCompleted);

#line default
#line hidden
            EndContext();
            BeginContext(883, 56, true);
            WriteLiteral("</td>\n                    <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 939, "\"", 964, 2);
            WriteAttributeValue("", 946, "Task/Edit/", 946, 10, true);
#line 32 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Index.cshtml"
WriteAttributeValue("", 956, item.id, 956, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(965, 35, true);
            WriteLiteral(">Update</td>\n                </tr>\n");
            EndContext();
#line 34 "/home/daiane/Documentos/Projetos/ToDoList/Views/Task/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1014, 41, true);
            WriteLiteral("        </table>\n    </fieldset>  \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDoList.Models.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591
