#pragma checksum "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "824a1d7ca3318588916e43988aa0fbb5760afa4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Db_Index), @"mvc.1.0.view", @"/Views/Db/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\_ViewImports.cshtml"
using UpmessageMVCNETCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\_ViewImports.cshtml"
using UpmessageMVCNETCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824a1d7ca3318588916e43988aa0fbb5760afa4e", @"/Views/Db/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f390c3fe7c21e5a5c2362792afc2cf8e8c19dd51", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Db_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UpmessageMVCNETCore.PostBL>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet1.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
  
    Layout = null;
    ViewBag.Title = "Index";
    var i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
  
    void indent(int level)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
         for (var i = 0; i < level; i++)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("   &nbsp; &nbsp; ");
#nullable restore
#line 15 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
                                          
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
         for (var i = 0; i < level; i++)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("  ```");
#nullable restore
#line 19 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
                              
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
         

    }

    void WriteChildren(IList<UpmessageMVCNETCore.PostBL> children,  int stackLevel)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
         foreach (var post in children)
        {
            var i = stackLevel;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n");
#nullable restore
#line 41 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
                  indent(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 42 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
           Write(Html.DisplayFor(modelItemx => post.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 44 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
            if (post.Children.Count > 0) {
                i++;
                WriteChildren(post.Children, i);
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824a1d7ca3318588916e43988aa0fbb5760afa4e7920", async() => {
                WriteLiteral(@"
<script type='text/javascript'>
  window.smartlook||(function(d) {
    var o=smartlook=function(){ o.api.push(arguments)},h=d.getElementsByTagName('head')[0];
    var c=d.createElement('script');o.api=new Array();c.async=true;c.type='text/javascript';
    c.charset='utf-8';c.src='https://rec.smartlook.com/recorder.js';h.appendChild(c);
    })(document);
    smartlook('init', '24dcdc2dd040c8f0b66b7f5a662a654a1ed9d097');
</script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "824a1d7ca3318588916e43988aa0fbb5760afa4e8622", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "824a1d7ca3318588916e43988aa0fbb5760afa4e9800", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "824a1d7ca3318588916e43988aa0fbb5760afa4e10978", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824a1d7ca3318588916e43988aa0fbb5760afa4e12865", async() => {
                WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 72 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n</p>\r\n\r\n\r\n");
#nullable restore
#line 76 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"box\">\r\n        <div>\r\n            <div>\r\n                ");
#nullable restore
#line 82 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div>");
#nullable restore
#line 84 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
            Write(Html.DisplayFor(modelItem => item.UserID));

#line default
#line hidden
#nullable disable
                WriteLiteral("&nbsp;&nbsp;");
#nullable restore
#line 84 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 87 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>");
#nullable restore
#line 89 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
        Write(Html.DisplayFor(modelItem => item.ParentID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 90 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
          
            WriteChildren(item.Children, 1);
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
#nullable restore
#line 94 "C:\Users\Administrator\Documents\UpmessageMVCNETCore\Views\Db\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UpmessageMVCNETCore.PostBL>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
