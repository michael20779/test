#pragma checksum "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2472e0fc8f12d4d77df33a363d9c734ad07353b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactEms1_Index), @"mvc.1.0.view", @"/Views/ContactEms1/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2472e0fc8f12d4d77df33a363d9c734ad07353b", @"/Views/ContactEms1/Index.cshtml")]
    public class Views_ContactEms1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<corewebapioracle.Data.ContactEm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CrmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CrmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1167, "\"", 1197, 1);
#nullable restore
#line 46 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
WriteAttributeValue("", 1182, item.ContactId, 1182, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1250, "\"", 1280, 1);
#nullable restore
#line 47 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
WriteAttributeValue("", 1265, item.ContactId, 1265, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1335, "\"", 1365, 1);
#nullable restore
#line 48 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
WriteAttributeValue("", 1350, item.ContactId, 1350, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<corewebapioracle.Data.ContactEm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
