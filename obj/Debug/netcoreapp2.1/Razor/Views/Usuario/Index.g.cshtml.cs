#pragma checksum "C:\Users\44846245837\Desktop\Senai.Projeto.Carfel\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdfbca21560c3010d1d009640f2be41efdd0c9ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdfbca21560c3010d1d009640f2be41efdd0c9ae", @"/Views/Usuario/Index.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-BR\">\r\n\r\n");
            EndContext();
            BeginContext(40, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc356aae4b44644a602a87d6b701e94", async() => {
                BeginContext(46, 289, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Carfel - Check Point</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""css/style.css"" />
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
            BeginContext(342, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(346, 9024, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a26d3945ac44568f5379b3e76b4b56", async() => {
                BeginContext(352, 9011, true);
                WriteLiteral(@"
    <nav class=""menu_desk"">
        <div class=""menu"">
            <div class=""container"">
                <div class=""logo"">
                    <img src=""imagens/logo.png"">
                </div>
                <div class=""itens"">
                    <ul>
                        <a href=""index.html"">
                            <li>HOME</li>
                        </a>
                        <a href=""/Usuario/Login"">
                            <li>LOGAR</li>
                        </a>
                    </ul>
                </div>
                <nav class=""menu_mobile"">
                    <a href=""#menu"" class=""btnMenu btnMenu_open"">Menu</a>
                    <ul class=""unme"" id=""menu"">
                        <li class=""btnMenu btnMenu_close"">Sair</li>
                        <li class=""menu_item"">
                            <a href=""index.html"" class=""menu_item_action"">home</a>
                        </li>
                        <li class=""menu_item"">
            ");
                WriteLiteral(@"                <a href=""html/contatos.html"" class=""menu_item_action"">contatos</a>
                        </li>
                        <li class=""menu_item"">
                            <a href=""html/faq.html"" class=""menu_item_action"">faq</a>
                        </li>
                        <li class=""menu_item"">
                            <a href=""html/sobre.html"" class=""menu_item_action"">sobre a empresa</a>
                        </li>
                    </ul>
                </nav>
            </div>
        </div>
    </nav>
    <section>
        <div class=""opacity"">
            <div class=""banner""></div>
        </div>
    </section>
    <section class=""container column"">
        <section class=""title"">
            <h1>Check Point</h1>
        </section>
        <div class=""text1"">
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Enim, accusamus? Voluptatibus aut ducimus illo molestias molestiae
            pariatur iure voluptatum impedit, nobis por");
                WriteLiteral(@"ro incidunt omnis hic, unde magni obcaecati. Beatae, corporis. Lorem
            ipsum dolor sit amet consectetur adipisicing elit. Enim, accusamus? Voluptatibus aut ducimus illo molestias molestiae
            pariatur iure voluptatum impedit, nobis porro incidunt omnis hic, unde magni obcaecati. Beatae, corporis. Lorem
            ipsum dolor sit amet consectetur adipisicing elit. Enim, accusamus? Voluptatibus aut ducimus illo molestias molestiae
            pariatur iure voluptatum impedit, nobis porro incidunt omnis hic, unde magni obcaecati. Beatae, corporis. Lorem
            ipsum dolor sit amet consectetur adipisicing elit. Enim, accusamus? Voluptatibus aut ducimus illo molestias molestiae
            pariatur iure voluptatum impedit, nobis porro incidunt omnis hic, unde magni obcaecati. Beatae, corporis.
        </div>
        <section class=""function"">
            <h2>Funcionalidades</h2>
            <div class=""bar_itens"">
                <div class=""so_pra_barrinha"">
                  ");
                WriteLiteral(@"  <div class=""bar_item1"">
                        <div class=""bar_espec"">
                            dihijdhffihd
                        </div>
                        <div class=""bar_text"">
                            <p>Lorem Ipsum</p>
                        </div>
                    </div>
                    <div class=""barrinha""></div>
                </div>
                <div class=""so_pra_barrinha"">
                    <div class=""bar_item1"">
                        <div class=""bar_espec"">
                            dihijdhffihd
                        </div>
                        <div class=""bar_text"">
                            <p>Lorem Ipsum</p>
                        </div>
                    </div>
                    <div class=""barrinha""></div>
                </div>
            </div>
            <div class=""bar""></div>
            <div class=""bar_itens"">
                <div class=""so_pra_barrinha2"">
                    <div class=""barrinha""></div>
       ");
                WriteLiteral(@"             <div class=""bar_item2"">
                        <div class=""bar_espec"">
                            dihijdhffihd
                        </div>
                        <div class=""bar_text"">
                            <p>Lorem Ipsum</p>
                        </div>
                    </div>
                </div>
                <div class=""so_pra_barrinha2"">
                    <div class=""barrinha""></div>
                    <div class=""bar_item2"">
                        <div class=""bar_espec"">
                            dihijdhffihd
                        </div>
                        <div class=""bar_text"">
                            <p>Lorem Ipsum</p>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <h2 class=""title_preco"">Preços Check Point</h2>
        <section class=""precos"">
            <div class=""preco_item"">
                <div class=""name"">
                    FREE
      ");
                WriteLiteral(@"          </div>
                <div class=""icon"">
                    <img src=""imagens/money.svg"" width=""200px"" height=""200px"">
                </div>
                <div class=""item_preco"">
                    R$ 00,00
                </div>
                <div class=""button_saiba"">
                    <a href=""html/contatos.html"">Saiba Mais</a>
                </div>
            </div>
            <div class=""preco_item"">
                <div class=""name"">
                    PRO
                </div>
                <div class=""icon"">
                    <img src=""imagens/money_purple.svg"" width=""200px"" height=""200px"">
                </div>
                <div class=""item_preco"">
                    R$ 19,99
                </div>
                <div class=""button_saiba"">
                    <a href=""html/contatos.html"">Saiba Mais</a>
                </div>
            </div>
            <div class=""preco_item"">
                <div class=""name"">
                    PREM");
                WriteLiteral(@"IUM
                </div>
                <div class=""icon"">
                    <img src=""imagens/medal.svg"" width=""200px"" height=""200px"">
                </div>
                <div class=""item_preco"">
                    R$ 199,99
                </div>
                <div class=""button_saiba"">
                    <a href=""html/contatos.html"">Saiba Mais</a>
                </div>
            </div>
        </section>
        <section class=""container"">
            <div class=""sobre_nos"">
                <div class=""sobre_img"">
                    <img src=""imagens/people-woman-coffee-meeting.jpg"" width=""600px"" height=""426px"">
                </div>
                <div class=""sobre_text"">
                    <h2>SOBRE A EMPRESA</h2>
                    <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Eligendi voluptas saepe quam assumenda asperiores dolores,
                    cumque accusamus odit nisi alias dolore aperiam quasi aliquid. Numquam maxime iure dicta offici");
                WriteLiteral(@"a quia.</p>
                    <div class=""button_sobre"">
                        <a href=""html/sobre.html"">Saiba Mais</a>    
                    </div>    
                </div>
            </div>
        </section>
    </section>
    <div class=""chat"">
        <div class=""chat_int"">
            <img src=""imagens/if_chat_326503.svg"" alt=""#"" width=""40px"" height=""40px"">
        </div>
    </div>
    <footer class=""rodape"">
        <div class=""container footerzao"">
            <div class=""descript"">
                <div class=""logo_footer"">
                    <img src=""imagens/logo.png"" alt=""#"">
                    <p>Carfel</p>
                </div>
                <div class=""text_footer"">
                    <p>Lorem ipsum dolor sit amet,<br>
                    consectetuer adipiscing elit. </p>
                </div>
            </div>
            <div class=""quebra_branca""></div>
            <div class=""middle_footer"">
                <div class=""middle_title"">CONTACT INFO<");
                WriteLiteral(@"/div>
                <div class=""middle_contact"">
                    <span>Email: example@example.com</span>
                    <span>Telefone: (XX) XXXXX-XXXX</span>
                </div>
                <div class=""middle_icons"">
                    <img src=""imagens/if_06-facebook_104498.svg"" alt=""#"">
                    <img src=""imagens/if_03-twitter_104501.svg"" alt="""">
                    <img src=""imagens/if_social-linkedin_216394.svg"" alt="""">
                    <img src=""imagens/if_33-pinterest_104469.svg"" alt="""">
                </div>
            </div>
            <div class=""quebra_branca""></div>
            <div class=""mapinha"">
                <img src=""imagens/mapinha.png"" alt=""#"">
            </div>
        </div>
    </footer>

    <script src=""js/main.js""></script>
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
            BeginContext(9370, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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