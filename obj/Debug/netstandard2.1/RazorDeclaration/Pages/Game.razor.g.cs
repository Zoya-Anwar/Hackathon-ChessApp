#pragma checksum "c:\Users\gwyd0\OneDrive\Documents\Hackathon\Pages\Game.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a04c7baee88b4e37cea307a11850a43b61c221d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Projects.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\_Imports.razor"
using Projects.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Game")]
    public partial class Game : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "c:\Users\gwyd0\OneDrive\Documents\Hackathon\Pages\Game.razor"
       
    Chess game = new Chess();
    public void play()
    {
        game.main();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
