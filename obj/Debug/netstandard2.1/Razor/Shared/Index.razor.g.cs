#pragma checksum "C:\Users\gwyd0\OneDrive\Documents\Hackathon\Shared\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1495ffe33053393b747f4abe7d095394ab40c96d"
// <auto-generated/>
#pragma warning disable 1591
namespace Projects.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Projects.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Voice Chess</h1>\r\n\r\nA chess solution with inbuilt voice commands.\r\n\r\n");
            __builder.OpenComponent<Projects.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "If you are enjoying our app. Please let the dev team know with an email");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591