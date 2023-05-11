#pragma checksum "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe08852f0675d739f9fadf11804116ab645e80a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe08852f0675d739f9fadf11804116ab645e80a", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Entities.Dtos.CategoryListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Kategoriler Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Success)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card mb-4 mt-2"">
                            <div class=""card-header"">
                                <i class=""fas fa-table mr-1""></i>
                                Kategoriler
                            </div>
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""categoriesTable"" width=""100%"" cellspacing=""0"">
                                        <thead>
                                            <tr>
                                                <th>ID</th>
                                                <th>Adı</th>
                                                <th>Açıklaması</th>
                                                <th>Aktif Mi?</th>
                                                <th>Silinmiş Mi?</th>
                                                <th>Not</th>
                                                <th>Ol");
            WriteLiteral(@"uşturulma Tarihi</th>
                                                <th>Oluşturan Kullanıcı Adı</th>
                                                <th>Son Düzenlenme Tarihi</th>
                                                <th>Son Düzenleyen Kullanıcı Adı</th>
                                            </tr>
                                        </thead>
                                        <tfoot>
                                            <tr>
                                                <th>ID</th>
                                                <th>Adı</th>
                                                <th>Açıklaması</th>
                                                <th>Aktif Mi?</th>
                                                <th>Silinmiş Mi?</th>
                                                <th>Not</th>
                                                <th>Oluşturulma Tarihi</th>
                                                <th>Oluşturan Kullanıcı Adı</th>
");
            WriteLiteral(@"                                                <th>Son Düzenlenme Tarihi</th>
                                                <th>Son Düzenleyen Kullanıcı Adı</th>
                                            </tr>
                                        </tfoot>
                                        <tbody>
");
#nullable restore
#line 46 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                             foreach (var category in Model.Categories)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 49 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 50 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 51 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 52 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 53 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 54 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 55 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 56 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 57 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.ModifiedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 58 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                   Write(category.ModifiedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 60 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 66 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        ");
#nullable restore
#line 70 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n        Dashboard sayfasına geri dönmek için lütfen ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fe08852f0675d739f9fadf11804116ab645e80a12430", async() => {
                WriteLiteral("tıklayınız.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 73 "D:\NetCoreRepos\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function() {
            $('#categoriesTable').DataTable({
                dom: 
                    ""<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>"" +
                        ""<'row'<'col-sm-12'tr>>"" +
                        ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
                buttons: [
                    {
                        text: 'Ekle',
                        className:'btn btn-success',
                        action: function ( e, dt, node, config ) {
                            alert( 'Ekle butonuna basıldı.' );
                        }
                    },
                    {
                        text: 'Yenile',
                        className:'btn btn-warning',
                        action: function ( e, dt, node, config ) {
                        alert( 'Yenile butonuna basıldı.' );
                         }
                        }
                ],
                language:{
                    ""s");
                WriteLiteral(@"Decimal"":        "","",
                    ""sEmptyTable"":     ""Tabloda herhangi bir veri mevcut değil"",
                    ""sInfo"":           ""_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor"",
                    ""sInfoEmpty"":      ""Kayıt yok"",
                    ""sInfoFiltered"":   ""(_MAX_ kayıt içerisinden bulunan)"",
                    ""sInfoPostFix"":    """",
                    ""sInfoThousands"":  ""."",
                    ""sLengthMenu"":     ""Sayfada _MENU_ kayıt göster"",
                    ""sLoadingRecords"": ""Yükleniyor..."",
                    ""sProcessing"":     ""İşleniyor..."",
                    ""sSearch"":         ""Ara:"",
                    ""sZeroRecords"":    ""Eşleşen kayıt bulunamadı"",
                    ""oPaginate"": {
                        ""sFirst"":    ""İlk"",
                        ""sLast"":     ""Son"",
                        ""sNext"":     ""Sonraki"",
                        ""sPrevious"": ""Önceki""
                    },
                    ""oAria"": {
             ");
                WriteLiteral(@"           ""sSortAscending"":  "": artan sütun sıralamasını aktifleştir"",
                        ""sSortDescending"": "": azalan sütun sıralamasını aktifleştir""
                    },
                    ""select"": {
                        ""rows"": {
                            ""_"": ""%d kayıt seçildi"",
                            ""0"": """",
                            ""1"": ""1 kayıt seçildi""
                        }
                    }
                }
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Entities.Dtos.CategoryListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
