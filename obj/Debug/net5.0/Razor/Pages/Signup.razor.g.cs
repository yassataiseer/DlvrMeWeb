#pragma checksum "/Users/yassa/DlvrMeWeb/Pages/Signup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49efa02cc73b28d108da3659fd2f134d79ff237"
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
#line 42 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
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
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, "<head><link href=\"/css/login.css\" rel=\"stylesheet\" type=\"text/css\">\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"></head>\r\n");
            __builder.AddMarkupContent(3, "<div class=\"topnav\"><a><h1>DlvrMe-Signup</h1></a></div>\r\n");
            __builder.OpenElement(4, "body");
            __builder.AddMarkupContent(5, "<br>\r\n <br>\r\n <br>\r\n <br>\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.AddMarkupContent(10, "<label for=\"uname\"><h3><b>Username</b></h3></label>\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "placeholder", "Enter Username");
            __builder.AddAttribute(14, "required");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
                                                            Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.AddMarkupContent(18, "<label for=\"psw\"><h3><b>Password</b></h3></label>\r\n    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "password");
            __builder.AddAttribute(21, "placeholder", "Enter Password");
            __builder.AddAttribute(22, "required");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
                                                                Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.AddMarkupContent(26, "<label for=\"psw\"><h3><b>Repeat Password</b></h3></label>\r\n    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "password");
            __builder.AddAttribute(29, "placeholder", "Repeat Password");
            __builder.AddAttribute(30, "required");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
                                                                Rep_Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Rep_Password = __value, Rep_Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "wrapper");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn");
            __builder.AddAttribute(38, "type", "submit");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"
                                                Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Sign Up");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    <br>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(42, "<a href=\"/\">Already a user? Login!</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"

    private string Username;
    private string Password;
    private string Rep_Password;
    private async void Submit(){
      if ((!string.IsNullOrWhiteSpace(Username)&&!string.IsNullOrWhiteSpace(Password)&&!string.IsNullOrWhiteSpace(Rep_Password))&&Rep_Password==Password){
        using var client = new HttpClient();
        var byteArray = Encoding.ASCII.GetBytes("Yassa Taiseer:yassa123");
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",Convert.ToBase64String(byteArray));
        var result = await client.GetStringAsync("https://dlvrapi.pythonanywhere.com/Users/mk_user/"+Username+"/"+Password);
        dynamic data = JObject.Parse(result);
        Console.WriteLine(data.Status);
        if (data.Status=="true"){
          NavManager.NavigateTo("/home",true); 
        } 
        else {
          await JsRuntime.InvokeVoidAsync("alert", "This Username Is Already Taken");
        }
      }
      else{
        //Console.WriteLine("MISTAKE");
          await JsRuntime.InvokeVoidAsync("alert", "Invalid Credentials!");
      }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
