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
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "/Users/yassa/DlvrMeWeb/Pages/Signup.razor"

    private string Username;
    private string Password;
    private string Rep_Password;
    private async void Submit(){
      Console.WriteLine(Username);
      if ((!string.IsNullOrWhiteSpace(Username)&&!string.IsNullOrWhiteSpace(Password)&&!string.IsNullOrWhiteSpace(Rep_Password))&&Rep_Password==Password){
        Console.WriteLine("YAY");
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
    }
}
#pragma warning restore 1591
