#pragma checksum "/Users/yassa/DlvrMeWeb/Pages/Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "220d47a6bc3b9f65996ac96d08a79c1cfca5f3ec"
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
#line 2 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, @"<head><link href=""/css/login.css"" rel=""stylesheet"" type=""text/css"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css""></head>
");
            __builder.AddMarkupContent(3, "<div class=\"topnav\"><h1>Orders</h1></div>\r\n");
            __builder.OpenElement(4, "body");
            __builder.AddMarkupContent(5, "<br>\r\n <br>\r\n <br>\r\n <br>");
#nullable restore
#line 24 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
 foreach (var specificData in UserData)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.OpenElement(10, "h2");
            __builder.OpenElement(11, "u");
            __builder.OpenElement(12, "b");
            __builder.AddContent(13, 
#nullable restore
#line 28 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
               specificData.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "h6");
            __builder.AddMarkupContent(16, "<b>The Address is:</b> ");
            __builder.AddContent(17, 
#nullable restore
#line 29 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
                                specificData.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "h6");
            __builder.AddMarkupContent(20, "<b>The Item is:</b> ");
            __builder.AddContent(21, 
#nullable restore
#line 30 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
                             specificData.Item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "h6");
            __builder.AddMarkupContent(24, "<b>The Price is:</b> ");
            __builder.AddContent(25, 
#nullable restore
#line 31 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
                              specificData.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    \r\n    ");
            __builder.OpenElement(27, "h6");
            __builder.AddMarkupContent(28, "<b>The Description is:</b> ");
            __builder.AddContent(29, 
#nullable restore
#line 33 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
                                    specificData.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "wrapper");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn_del");
            __builder.AddAttribute(35, "type", "submit");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
                                                    () => Delete(specificData.Name,specificData.Address,specificData.Item,specificData.Price,specificData.Description)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    <br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n<br>");
#nullable restore
#line 43 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<a href=\"/Form\" class=\"float\"><i class=\"fa fa-plus my-float\"></i></a>\r\n");
            __builder.AddMarkupContent(41, "<h6>If you dont see anything it means you have no orders</h6>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
    private List<orderData> UserData = new();
    public string Username;
    public string Name;
    private async void ViewData  (){

            using var client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes("Yassa Taiseer:yassa123");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",Convert.ToBase64String(byteArray));
            Username = await JsRuntime.InvokeAsync<string>("ReadCookie.ReadCookie",  "Username");

            Console.WriteLine(Username);
            Console.WriteLine("Username");

            var result = await client.GetStringAsync("https://dlvrapi.pythonanywhere.com/Orders/spec_order/"+Username);

            JArray data = JArray.Parse(result);
            foreach (dynamic obj in data){
                    UserData.Add(new orderData(){
                    Address = obj.Address,
                    Description  = obj.Description, 
                    Item = obj.Item, 
                    Latitude = obj.Latitude, 
                    Longitude = obj.Longitude, 
                    Name = obj.Name, 
                    Price = obj.Price
                });
            }
            StateHasChanged();
            
    }
    
    private async void  Delete(string Username,string Address,string Item,double Price,string User_info){
        using var client = new HttpClient();
        Console.WriteLine(Price.ToString(".0##"));
        var byteArray = Encoding.ASCII.GetBytes("Yassa Taiseer:yassa123");
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",Convert.ToBase64String(byteArray)); 
        var result = await client.GetStringAsync("https://dlvrapi.pythonanywhere.com/Orders/del_order/"+Username+"/"+Address+"/"+Item+"/"+Price.ToString(".0##")+"/"+User_info);
        dynamic data = JObject.Parse(result);
        Console.WriteLine(data);
        NavManager.NavigateTo("/home",true); 
           }

    protected override async Task OnInitializedAsync()
    {

        ViewData();
       
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LocalStorage Storage { get; set; }
    }
}
#pragma warning restore 1591
