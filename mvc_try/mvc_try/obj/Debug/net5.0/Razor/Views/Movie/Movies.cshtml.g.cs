#pragma checksum "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "758b37be3ccabea045b0f45ff653f1facd33b2c74f550d490bd82329a0ddd36e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Movies), @"mvc.1.0.view", @"/Views/Movie/Movies.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\reactjs-mvc\mvc_try\mvc_try\Views\_ViewImports.cshtml"
using mvc_try.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"758b37be3ccabea045b0f45ff653f1facd33b2c74f550d490bd82329a0ddd36e", @"/Views/Movie/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"293a991493d8547880e6b993aa474a9e7c9d4045aeb5776f7d7894ca6bc792e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoviesVievModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n    <h1>Film Listesi</h1>\r\n    \r\n\r\n    <div id=\"filmler\">\r\n\r\n");
#nullable restore
#line 10 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
     if (Model.Movies.Count() > 0)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
         foreach (var movie in Model.Movies)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
       Write(await Html.PartialAsync("_movie", movie));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
                                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
         


    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\"> Film Bulunamadı! </div>\r\n");
#nullable restore
#line 21 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n    </div>\r\n");
#nullable restore
#line 25 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
     if (TempData["Message"] != null)
    {
        

#line default
#line hidden
#nullable disable
            DefineSection("message", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 28 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
Write(await Html.PartialAsync("_message",(string)TempData["Message"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
            }
            );
#nullable restore
#line 30 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
     

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("menu", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
#nullable restore
#line 39 "D:\reactjs-mvc\mvc_try\mvc_try\Views\Movie\Movies.cshtml"
Write(await Component.InvokeAsync("Genres"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesVievModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
