#pragma checksum "C:\Users\44846245837\Desktop\Senai.Projeto.Carfel\Views\Shared\MasterPageUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd11ef3defd4ae9ea4647d3c1d8247957a1e5a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MasterPageUsuario), @"mvc.1.0.view", @"/Views/Shared/MasterPageUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MasterPageUsuario.cshtml", typeof(AspNetCore.Views_Shared_MasterPageUsuario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd11ef3defd4ae9ea4647d3c1d8247957a1e5a1", @"/Views/Shared/MasterPageUsuario.cshtml")]
    public class Views_Shared_MasterPageUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "089d51d6fb7444faade7e901a9c78128", async() => {
                BeginContext(31, 280, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Page Title</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""/css/style.css"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(318, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(320, 2094, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d49af562d4fb4e2cbe46fb470e9932c3", async() => {
                BeginContext(326, 628, true);
                WriteLiteral(@"
    <nav class=""menu_desk"">
        <div class=""menu"">
            <div class=""container"">
                <div class=""logo"">
                    <img src=""/imagens/logo.png"">
                </div>
                <div class=""itens"">
                    <ul>
                        <a href=""/Usuario/Index"">
                            <li>HOME</li>
                        </a>
                        <a href=""/Usuario/Login"">
                            <li>LOGAR</li>
                        </a>
                    </ul>
                </div>
            </div>
        </div>
    </nav>
    
    ");
                EndContext();
                BeginContext(955, 12, false);
#line 31 "C:\Users\44846245837\Desktop\Senai.Projeto.Carfel\Views\Shared\MasterPageUsuario.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(967, 1440, true);
                WriteLiteral(@"

    <footer class=""rodape"">
        <div class=""container footerzao"">
            <div class=""descript"">
                <div class=""logo_footer"">
                    <img src=""/imagens/logo.png"" alt=""#"">
                    <p>Carfel</p>
                </div>
                <div class=""text_footer"">
                    <p>Lorem ipsum dolor sit amet,<br>
                    consectetuer adipiscing elit. </p>
                </div>
            </div>
            <div class=""quebra_branca""></div>
            <div class=""middle_footer"">
                <div class=""middle_title"">CONTACT INFO</div>
                <div class=""middle_contact"">
                    <span>Email: example@example.com</span>
                    <span>Telefone: (XX) XXXXX-XXXX</span>
                </div>
                <div class=""middle_icons"">
                    <img src=""/imagens/if_06-facebook_104498.svg"" alt=""#"">
                    <img src=""/imagens/if_03-twitter_104501.svg"" alt="""">
                 ");
                WriteLiteral(@"   <img src=""/imagens/if_social-linkedin_216394.svg"" alt="""">
                    <img src=""/imagens/if_33-pinterest_104469.svg"" alt="""">
                </div>
            </div>
            <div class=""quebra_branca""></div>
            <div class=""mapinha"">
                <img src=""/imagens/mapinha.png"" alt=""#"">
            </div>
        </div>
    </footer>

    <script src=""/js/main.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2414, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
