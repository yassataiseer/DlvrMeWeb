#pragma checksum "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4dc639ae6088df63173b9169ed6ade49224488d"
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
#line 2 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/map")]
    public partial class OrderMap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\n");
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, @"<head><link href=""/css/login.css"" rel=""stylesheet"" type=""text/css"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css""></head>
");
            __builder.AddMarkupContent(3, "<div class=\"topnav\"><h1>Map Of Orders</h1></div>\n\n");
            __builder.OpenElement(4, "body");
            __builder.AddMarkupContent(5, "<br>\n    <br>\n    <br>\n    <br>\n    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
                                    ReDirect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "<i class=\"fa fa-map\"></i> Home ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, " \n\n\n\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(11);
            __builder.AddAttribute(12, "style", "width:100%; height: 500px;");
            __builder.AddAttribute(13, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 31 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
                                                                   zoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 31 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
                                                                                 new GoogleMapPosition() { Lat = Lat, Lng = Long }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "MarkerClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenGoogleMapMarker>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenGoogleMapMarker>(this, 
#nullable restore
#line 31 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
                                                                                                                                                  OnMarkerClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 33 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
                 foreach (var specificData in AllData){
                    string text = "The address is: "+@specificData.Address+"\n"+" The Item is: "+@specificData.Item+"\n"+" The Price is: "+@specificData.Price.ToString("0.000000")+"\n"+" Excess Info: "+@specificData.Description;
                    

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(17);
                __builder2.AddAttribute(18, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
                                                   text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 35 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
                                                                   new GoogleMapPosition() { Lat = @specificData.Latitude, Lng = @specificData.Longitude }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 36 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\n\n\n\n");
            __builder.AddMarkupContent(21, "<h2>something here</h2>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "/Users/yassa/DlvrMeWeb/Pages/OrderMap.razor"
    private List<orderData> AllData = new();
    private double Lat = 42.6977;
    private double Long = 23.3219;
    private  void  ReDirect(){
        NavManager.NavigateTo("/home",true); 
    }
    private async void ViewData  (){

            using var client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes("Yassa Taiseer:yassa123");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic",Convert.ToBase64String(byteArray));
            var result = await client.GetStringAsync("https://dlvrapi.pythonanywhere.com/Orders/all_order");

            JArray data = JArray.Parse(result);
            foreach (dynamic obj in data){
                    AllData.Add(new orderData(){
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
    int zoom = 3;


    private async void OnMarkerClick(RadzenGoogleMapMarker marker)
    {
        Console.WriteLine(marker.Title);
        Lat = marker.Position.Lat;
        Long = marker.Position.Lng;
        await JsRuntime.InvokeVoidAsync("alert", marker.Title);

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
