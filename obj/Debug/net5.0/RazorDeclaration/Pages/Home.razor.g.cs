// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "/Users/yassa/DlvrMeWeb/Pages/Home.razor"
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
    
        protected override async Task OnAfterRenderAsync(bool firstRender)
{
    if (firstRender)
    {

        //Name = await Storage.GetItemAsync("Username");
        StateHasChanged();
    }
}

    protected override async Task OnInitializedAsync()
    {
       //await OnAfterRenderAsync(true);

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
