#pragma checksum "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f41ab96ade401ee5f1b5071aa7e69084ce202cf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\_ViewImports.cshtml"
using Ponya_Back;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\_ViewImports.cshtml"
using Ponya_Back.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\_ViewImports.cshtml"
using Ponya_Back.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\_ViewImports.cshtml"
using Ponya_Back.ViewModel.AboutViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\_ViewImports.cshtml"
using Ponya_Back.ViewModel.BlogViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\_ViewImports.cshtml"
using Ponya_Back.ViewModel.PortfolioViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\_ViewImports.cshtml"
using Ponya_Back.ViewModel.PortfolioDetailViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\_ViewImports.cshtml"
using Ponya_Back.ViewModel.ServiceViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41ab96ade401ee5f1b5071aa7e69084ce202cf6", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cc137538b0dcc96f3faf2118581abe413ab8b4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\admin\OneDrive\İş masası\Ponya\Ponya\Ponya-Back\Ponya-Back\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- contact-Info -->
<section id=""port-info"" class=""about-bgcolor w-100 vh-40""
         style=""background-image: url(assets/image/index/white-pattern-long.png);"">
    <div class=""container pt-5"">
        <div class=""text-xxl-center pt-5"">
            <h4 class=""text-white pt-3 fs-65 tahoma text-uppercase text-decoration-underline"">
                Contact Us
            </h4>
            <a href=""index.html"" class=""pt-5 text-white fs-5"">
                <i class=""bi bi-house-fill ""></i>Home <i class=""bi bi-caret-right-fill""></i> Contact us
            </a>
        </div>
    </div>
</section>
<!-- Form -->
<section id=""form"" class=""pt-10 pb-5"">
    <div class=""container pt-4 pb-5"">
        <div class=""row pb-5"">
            <div class=""col-lg-6"">
                <span class=""coruier text-dark fw-bold"">Connect with us</span>
                <h3 class=""tahoma text-dark fs-1 fw-bold pt-3"">Let's get social</h3>
                <h3 class=""tahoma main-color fs-1 fw-bold"">Send message</h3>
 ");
            WriteLiteral(@"               <p class=""text-dark pt-2"">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut elit
                    tellus, luctus nec ullamcorper mattis, pulvinar dapibus leo.
                </p>
                <div id=""contact"" class=""row"">
                    <div class=""col-4"">
                        <ul class=""col"">
                            <li class=""list-unstyled"">
                                <button class="" btn main-bgcolor form-control-lg   fw-bold text-white contactbtn"">
                                    <a href=""contact.html"" class=""text-decoration-underline text-white "">
                                        <i class=""bi bi-messenger text-white me-3""></i>Messenger
                                    </a>
                                </button>
                            </li>
                            <li class=""list-unstyled pt-3"">
                                <button class=""  btn main-bgcolor form-control-lg  fw-bold text-white ");
            WriteLiteral(@"contactbtn"">
                                    <a href=""contact.html"" class=""text-decoration-underline text-white"">
                                        <i class=""bi bi-whatsapp text-white me-3""></i>Whatsapp
                                    </a>
                                </button>
                            </li>
                            <li class=""list-unstyled pt-3"">
                                <button class="" btn main-bgcolor form-control-lg  fw-bold text-white contactbtn"">
                                    <a href=""contact.html"" class=""text-decoration-underline text-white"">
                                        <i class=""bi bi-telegram text-white me-4""></i>Telegram
                                    </a>
                                </button>
                            </li>
                        </ul>
                    </div>
                    <div class=""col-4 rounded-3 m"" style=""background-color: rgb(223, 223, 223);"">
                        <p><i cl");
            WriteLiteral(@"ass=""bi bi-phone main-color me-3""></i>+66 99 828 7890</p>
                        <p><i class=""bi bi-envelope main-color me-3""></i>hello@ponyamedia.com</p>
                        <p>
                            <i class=""bi bi-geo-alt-fill main-color me-3""></i>1640 Simpson Avenue, Pennsylvania
                            PA 17401
                        </p>
                    </div>
                </div>
                <iframe class=""pt-4""
                        src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.748317523108!2d49.813257115705156!3d40.37010466639721!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307dc397d94dc3%3A0x617bc46b47244c00!2sAzerbaijan%20Technical%20University!5e0!3m2!1sen!2s!4v1656064599337!5m2!1sen!2s""
                        width=""550"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4002, "\"", 4020, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy""
                        referrerpolicy=""no-referrer-when-downgrade""></iframe>
            </div>
            <div class=""col-lg-6 rounded-3"" style=""background-color: rgb(223, 223, 223);"">
                <div class=""container "">
                    <h4 class=""text-dark fw-bold fs-1 tahoma"">Your Details</h4>
                    <p class=""text-muted"">Let us know how to get back to you.</p>
                    <hr>
                    <div class=""row g-3 pt-3"">
                        <div class=""col-sm-6"">
                            <label for=""firstName"" class=""form-label"">
                                First Name <span class=""main-color"">
                                    *
                                </span>
                            </label>
                            <input type=""text"" class=""form-control text-muted"" id=""firstName""
                                   placeholder=""Anderson""");
            BeginWriteAttribute("value", " value=\"", 4969, "\"", 4977, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 4978, "\"", 4989, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <span class=""fst-italic text-muted fw-light "">Enter your first name here</span>
                            <div class=""invalid-feedback"">
                                Valid first name is required.
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <label for=""firstName"" class=""form-label"">
                                Last Name <span class=""main-color"">
                                    *
                                </span>
                            </label>
                            <input type=""text"" class=""form-control text-muted"" id=""lastName"" placeholder=""Mikoo""");
            BeginWriteAttribute("value", "\r\n                                   value=\"", 5712, "\"", 5756, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 5757, "\"", 5768, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <span class=""fst-italic text-muted fw-light"">Enter your last name here</span>
                            <div class=""invalid-feedback"">
                                Valid first name is required.
                            </div>
                        </div>
                        <div class=""col-sm-6 pt-4"">
                            <label for=""firstName"" class=""form-label"">
                                Email Address <span class=""main-color"">
                                    *
                                </span>
                            </label>
                            <input type=""email"" class=""form-control text-muted"" id=""firstName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 6480, "\"", 6494, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                                   value=\"", 6495, "\"", 6539, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 6540, "\"", 6551, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <span class=""fst-italic text-muted fw-light"">Example: user@website.com</span>
                            <div class=""invalid-feedback"">
                                Valid first name is required.
                            </div>
                        </div>
                        <div class=""col-sm-6 pt-4"">
                            <label for=""firstName"" class=""form-label"">
                                Subject <span class=""main-color"">
                                    *
                                </span>
                            </label>
                            <input type=""text"" class=""form-control text-muted"" id=""lastName""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 7255, "\"", 7269, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                                   value=\"", 7270, "\"", 7314, 0);
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 7315, "\"", 7326, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <span class=""fst-italic text-muted fw-light"">How can we help you?</span>
                            <div class=""invalid-feedback"">
                                Valid first name is required.
                            </div>
                        </div>
                    </div>
                    <h5 class=""tahoma fs-5 fw-bold text-dark pt-4"">How can we help?</h5>
                    <p class=""text-muted fs-5"">Feel free to ask a question or simply leave a comment</p>
                    <hr class=""text-muted"">
                    <h5 class=""tahoma text-dark"">Comments/ Questions<span class=""main-color""> *</span></h5>
                    <textarea class=""form-control pt-3 """);
            BeginWriteAttribute("name", " name=\"", 8057, "\"", 8064, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 8065, "\"", 8070, 0);
            EndWriteAttribute();
            WriteLiteral(@" cols=""20"" rows=""10""></textarea>
                    <div class=""pt-5 pb-3"">
                        <button class=""btn  form-control-sm main-bgcolor fw-bold text-white"">
                            Send
                            Message
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Send-Message -->
<section id=""message"" class=""pt-10 pb-5"">
    <div class=""container pb-5"">
        <div class=""row pb-5"">
            <div class=""col-6 pb-5"">
                <h3 class=""fw-bold fs-65 text-dark"">Consult with us</h3>
                <h3 class=""main-color fw-bold fs-65"">For Free</h3>
                <p class=""text-black pt-3"">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut elit
                    tellus, luctus nec ullamcorper mattis, pulvinar dapibus leo.
                </p>
                <button class=""btn  form-control-lg main-bgcolor  "">
               ");
            WriteLiteral("     <a href=\"#form\" class=\"text-white fw-bold\">Send Message</a>\r\n                </button>\r\n            </div>\r\n            <div class=\"col-6 pb-5\">\r\n                <img src=\"assets/image/index/croods-4.png\" width=\"550\" height=\"350\"");
            BeginWriteAttribute("alt", " alt=\"", 9329, "\"", 9335, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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