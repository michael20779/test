#pragma checksum "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08180bba2196188f63c43e587554ecbbc20a8f09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactEms1_Details), @"mvc.1.0.view", @"/Views/ContactEms1/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08180bba2196188f63c43e587554ecbbc20a8f09", @"/Views/ContactEms1/Details.cshtml")]
    public class Views_ContactEms1_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<corewebapioracle.Data.ContactEm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ContactEm</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CrmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
       Write(Html.DisplayFor(model => model.CrmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1052, "\"", 1083, 1);
#nullable restore
#line 40 "C:\Users\Michael Mok\source\repos\CoreWebAPIOracle\corewebapioracle\corewebapioracle\Views\ContactEms1\Details.cshtml"
WriteAttributeValue("", 1067, Model.ContactId, 1067, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<corewebapioracle.Data.ContactEm> Html { get; private set; }
    }
}
#pragma warning restore 1591
