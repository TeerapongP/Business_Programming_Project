#pragma checksum "E:\Business_Programming_Project\Project\Project\Pages\information_suit_Sql.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "295e36ec5557e48e31ccc2efb0d3d3dcabef85ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.Pages.Pages_information_suit_Sql), @"mvc.1.0.razor-page", @"/Pages/information_suit_Sql.cshtml")]
namespace Project.Pages
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
#line 1 "E:\Business_Programming_Project\Project\Project\Pages\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Business_Programming_Project\Project\Project\Pages\information_suit_Sql.cshtml"
using MySql.Data.MySqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295e36ec5557e48e31ccc2efb0d3d3dcabef85ab", @"/Pages/information_suit_Sql.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7dae7ff6714ef70766776d91b193080525975d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_information_suit_Sql : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\Business_Programming_Project\Project\Project\Pages\information_suit_Sql.cshtml"
  
    var name_ = Request.Form["name_"];
    var lastName = Request.Form["lastName"];
    var idcard = Request.Form["idcard"];
    var phone_number = Request.Form["phone_number"];
    var blood_type = Request.Form["blood_type"];
    var congenital_disease = Request.Form["congenital_disease"];
    var booking_date = Request.Form["booking_date"];
    var address_user = Request.Form["address_user"];

    MySqlConnection conn;
    string server = "localhost";
    string database = "reservation_room";
    string uid = "root";
    string password = "12345678";
    string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
    conn = new MySqlConnection(connectionString);
    try
    {
        conn.Open();

    }
    catch (Exception ex)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>ติดต่อฐานข้อมูลไม่ได้!!!</p>\r\n");
#nullable restore
#line 30 "E:\Business_Programming_Project\Project\Project\Pages\information_suit_Sql.cshtml"
    }

    string sqlCmd = "INSERT suit_informations VALUES (@name_,@lastname,@ID_card_code,@telephone_number,@current_address,@blood_type,@congenital_disease,@lease)";

    MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);

    cmd.Parameters.AddWithValue("@name_", name_);
    cmd.Parameters.AddWithValue("@lastname", lastName);
    cmd.Parameters.AddWithValue("@ID_card_code", idcard);
    cmd.Parameters.AddWithValue("@telephone_number", phone_number);
    cmd.Parameters.AddWithValue("@current_address", address_user);
    cmd.Parameters.AddWithValue("@blood_type", blood_type);
    cmd.Parameters.AddWithValue("@congenital_disease", congenital_disease);
    cmd.Parameters.AddWithValue("@lease", booking_date);

    cmd.ExecuteNonQuery();

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        window.setTimeout(function () { window.location.href = \"./Home\" });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Pages.information_suit_SqlModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Pages.information_suit_SqlModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Pages.information_suit_SqlModel>)PageContext?.ViewData;
        public Project.Pages.information_suit_SqlModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
