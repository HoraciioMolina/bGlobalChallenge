#pragma checksum "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19950dbfec3bbf278e4e642cc43d95f047159a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_Create), @"mvc.1.0.view", @"/Views/Vehicle/Create.cshtml")]
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
#line 1 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\_ViewImports.cshtml"
using bGlobalChallgenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\_ViewImports.cshtml"
using bGlobalChallgenge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19950dbfec3bbf278e4e642cc43d95f047159a8f", @"/Views/Vehicle/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60c2b43b9a49a4e0158ab7bd40b920a9fac164e", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bGlobalChallgenge.Models.DTOs.Inputs.VehicleInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 12 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
   Write(Html.LabelFor(model => model.TitularFirstName, htmlAttributes: new { @class =  "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.EditorFor(model => model.TitularFirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.TitularFirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
   Write(Html.LabelFor(model => model.TitularLastName, htmlAttributes: new { @class =  "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.EditorFor(model => model.TitularLastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.TitularLastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 28 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
   Write(Html.LabelFor(model => model.Doors, htmlAttributes: new { @class =  "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.EditorFor(model => model.Doors, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Doors, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 36 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
   Write(Html.LabelFor(model => model.Model, htmlAttributes: new { @class =  "col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.EditorFor(model => model.Model, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 39 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Model, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 44 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
   Write(Html.LabelFor(model => model.BrandId, htmlAttributes: new { @class = "col-md-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.DropDownListFor(model => model.BrandId, Model.Brands, "Seleccione una marca", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 47 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.BrandId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"col-md-10\">\r\n            <input type=\"submit\" value=\"Guardar\" class=\"btn btn-primary\" />\r\n            ");
#nullable restore
#line 55 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
       Write(Html.ActionLink("Volver", "Index", new {estado="Activos" }, new { @class = "btn btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 58 "C:\Users\Horacio\Desktop\asd\bGlobalChallgenge\Views\Vehicle\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bGlobalChallgenge.Models.DTOs.Inputs.VehicleInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
