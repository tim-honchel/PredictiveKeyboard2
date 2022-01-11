#pragma checksum "C:\Users\timho\Documents\repos\FinalProjectKeyboard\FinalProjectKeyboard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb1cad013692b7f311b94996e05aedcfc12b9239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\timho\Documents\repos\FinalProjectKeyboard\FinalProjectKeyboard\Views\_ViewImports.cshtml"
using FinalProjectKeyboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\timho\Documents\repos\FinalProjectKeyboard\FinalProjectKeyboard\Views\_ViewImports.cshtml"
using FinalProjectKeyboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1cad013692b7f311b94996e05aedcfc12b9239", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2b650e9487ff30f6f68b352775303f66e5e87c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\timho\Documents\repos\FinalProjectKeyboard\FinalProjectKeyboard\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Keyboard Demo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <h1>Keyboard Demo</h1>
    <p>Test this alternative for devices like TV's and game consoles that lack a built-in keyboard.</p>
    <ol>
        <li>Use the 5 standard controls (up, down, left, right, and enter) to make a search query.</li>
        <li>The keyboard will calculate the probabilities of which character you will type next.</li>
        <li>The keys will be arranged accordingly to save you time.</li>
        <li>When you see your desired query on the far right, press enter, and scroll to select it.</li>
    </ol>
    <br>
    <br>
    <div class=""main-container"">
        <div class=""button-container"">
            <button id=""buttonUp"" type=""button"">Scroll Up</button>
            <br>
            <button id=""buttonLeft"" type=""button"">Backspace</button>
            <button id=""buttonCenter"" type=""button"">Enter</button>
            <button id=""buttonRight"" type=""button"">Space</button>
            <br>
            <br>
            <button id=""buttonDown"" type=""button"">Sc");
            WriteLiteral(@"roll Down</button>
        </div>
        <div class=""cursor-container"">
            <p id=""cursorTop"">#</p>
            <p id=""cursorUp"">#</p>
            <p id=""cursor1"">#</p>
            <p id=""cursor2"">#</p>
            <p id=""cursor3"">#</p>
            <p id=""cursor4"">#</p>
            <p id=""cursor5"">#</p>
            <p id=""cursor6"">#</p>
            <p id=""cursor7"">#</p>
            <p id=""cursorDown"">#</p>
            <p id=""cursorBottom"">#</p>
        </div>
        <div class=""keyboard-container"">
            <p id=""keyHeader"">123 .!?</p>
            <p id=""keyUp"">^</p>
            <p id=""key1"">A</p>
            <p id=""key2"">C</p>
            <p id=""key3"">M</p>
            <p id=""key4"">P</p>
            <p id=""key5"">S</p>
            <p id=""key6"">T</p>
            <p id=""key7"">U</p>
            <p id=""keyDown"">v</p>
            <p id=""keyFooter"">ABC</p>
        </div>
        <div class=""selection-container"">
            <p id=""selectionTop"">#</p>
            <p id=""se");
            WriteLiteral(@"lectionUp"">#</p>
            <p id=""selection1"">#</p>
            <p id=""selection2"">#</p>
            <p id=""selection3"">#</p>
            <p id=""selection4"">#</p>
            <p id=""selection5"">#</p>
            <p id=""selection6"">#</p>
            <p id=""selection7"">#</p>
            <p id=""selectionDown"">#</p>
            <p id=""selectionBottom"">#</p>
        </div>
        <div class=""results-container"">
            <p id =""searchString"">______________</p>
            <br>
            <p id =""result1"">a</p>
            <p id =""result2"">aardvark</p>
            <p id =""result3"">abacterial</p>
            <p id =""result4"">abacus</p>
            <p id =""result5"">abandon</p>
            <p id =""result6"">abandoned</p>
            <p id =""result7"">abandonment</p>
            <p id =""result8"">abase</p>
            <p id =""result9"">abashed</p>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
