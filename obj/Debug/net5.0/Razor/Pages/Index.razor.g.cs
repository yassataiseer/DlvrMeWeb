#pragma checksum "/Users/yassa/DlvrMeWeb/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "385472e977bd336c7f0757eabf48eb41c860c9ce"
// <auto-generated/>
#pragma warning disable 1591
namespace DlvrMeWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using DlvrMeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/yassa/DlvrMeWeb/_Imports.razor"
using DlvrMeWeb.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.AddMarkupContent(1, "<html><head><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n<style>\r\nbody {font-family: Arial, Helvetica, sans-serif;}\r\nform {border: 3px solid #f1f1f1;   \r\nbackground-color: rgb(255,254,225);\r\n}\r\nnavbar{\r\n    background-color:rgb(\t0, 35, 102);\r\n\r\n}\r\nh1{\r\n    color:rgb(\t0, 35, 102);\r\n}\r\ninput[type=text], input[type=password] {\r\n  width: 100%;\r\n  padding: 12px 20px;\r\n  margin: 8px 0;\r\n  display: inline-block;\r\n  border: 1px solid #ccc;\r\n  box-sizing: border-box;\r\n}\r\n\r\nbutton {\r\n    align:center;\r\n  background-color: rgb(255,254,225);\r\n  color: 0xff002366;\r\n  padding: 14px 20px;\r\n  text: rgb(0,35,102),\r\n  margin: 8px 0;\r\n  border: none;\r\n  cursor: pointer;\r\n  filter: drop-shadow(1px 1px 1px rgba(0.25, 0.25, 0.25, 0.25));\r\n  width: 20%;\r\n}\r\n\r\nbutton:hover {\r\n  opacity: 0.8;\r\n}\r\n\r\n.cancelbtn {\r\n  width: auto;\r\n  padding: 10px 18px;\r\n  background-color: #f44336;\r\n}\r\n\r\n.imgcontainer {\r\n  text-align: center;\r\n  margin: 24px 0 12px 0;\r\n}\r\n\r\nimg.avatar {\r\n  width: 40%;\r\n  border-radius: 50%;\r\n}\r\n\r\n.container {\r\n  padding: 16px;\r\n}\r\n\r\nspan.psw {\r\n  float: right;\r\n  padding-top: 16px;\r\n}\r\n\r\n@media screen and (max-width: 300px) {\r\n  span.psw {\r\n     display: block;\r\n     float: none;\r\n  }\r\n  .cancelbtn {\r\n     width: 100%;\r\n  }\r\n}\r\n</style></head>\r\n<body><navbar><h1>Login Form</h1></navbar>\r\n<form><div class=\"container\"><label for=\"uname\"><b>Username</b></label>\r\n    <input type=\"text\" placeholder=\"Enter Username\" name=\"uname\" required>\r\n\r\n    <label for=\"psw\"><b>Password</b></label>\r\n    <input type=\"password\" placeholder=\"Enter Password\" name=\"psw\" required>\r\n        \r\n    <button type=\"submit\">Login</button></div></form></body></html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
