#pragma checksum "/Users/yassa/DlvrMeWeb/Pages/Signup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb55fc51e9fbcadecd4d0e322b58460f371da940"
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
#nullable restore
#line 43 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class Signup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.AddMarkupContent(1, @"<html><head><link href=""/css/login.css"" rel=""stylesheet"" type=""text/css"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1""></head>
<div class=""topnav""><a><h1>DlvrMe-Signup</h1></a></div>
<body><br>
 <br>
 <br>
 <br>
<form><div class=""card""><div class=""container""><label for=""uname""><h3><b>Username</b></h3></label>
    <input type=""text"" placeholder=""Enter Username"" required>

    <label for=""psw""><h3><b>Password</b></h3></label>
    <input type=""password"" placeholder=""Enter Password"" required>
    <label for=""psw""><h3><b>Repeat Password</b></h3></label>
    <input type=""password"" placeholder=""Repeat Password"" required>
        <div class=""wrapper""><button class=""btn"" type=""submit"">Sign Up</button></div>
    <br>
    <br>
    <a href=""/"">Already a user? Login!</a></div></div></form></body></html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
