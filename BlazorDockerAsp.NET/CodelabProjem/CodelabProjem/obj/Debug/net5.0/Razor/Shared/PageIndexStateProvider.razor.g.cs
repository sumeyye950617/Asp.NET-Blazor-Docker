#pragma checksum "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Shared\PageIndexStateProvider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fb28c4a25be99026757a8fda2d6ac01757785e3"
// <auto-generated/>
#pragma warning disable 1591
namespace CodelabProjem.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using CodelabProjem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using CodelabProjem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\_Imports.razor"
using Helper;

#line default
#line hidden
#nullable disable
    public partial class PageIndexStateProvider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.CodelabProjem.Shared.PageIndexStateProvider.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Shared\PageIndexStateProvider.razor"
                       this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.AddContent(3, 
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Shared\PageIndexStateProvider.razor"
     ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\CodelabProjem\CodelabProjem\Shared\PageIndexStateProvider.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    public int PageIndex { get; set; } = 1;

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.CodelabProjem.Shared.PageIndexStateProvider
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
