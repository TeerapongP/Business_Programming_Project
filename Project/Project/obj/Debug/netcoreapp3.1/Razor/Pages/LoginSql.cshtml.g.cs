#pragma checksum "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0d85985c9cab1a4a9923e4b2f997d3d97e07ef8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.Pages.Pages_LoginSql), @"mvc.1.0.razor-page", @"/Pages/LoginSql.cshtml")]
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
#line 3 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
using MySql.Data.MySqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d85985c9cab1a4a9923e4b2f997d3d97e07ef8", @"/Pages/LoginSql.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7dae7ff6714ef70766776d91b193080525975d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoginSql : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
  
    var username_login = Request.Form["username-login"];
    var pass_login = Request.Form["pass-login"];

    MySqlConnection conn;
    string server = "localhost";
    string database = "Reservation_Room";
    string uid = "root";
    string password = "12345678";
    string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
    conn = new MySqlConnection(connectionString);
    try
    {
        conn.Open();

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>ติดต่อฐานข้อมูล</p>\r\n");
#nullable restore
#line 21 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
    }
    catch (Exception ex)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>ติดต่อฐานข้อมูลไม่ได้!!!</p>\r\n");
#nullable restore
#line 25 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
    }

    string sqlCmd = "SELECT * FROM login_signIn where username='" + username_login + "' AND pass='" + pass_login + "'";
    MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);
    MySqlDataReader dataReader = cmd.ExecuteReader();

    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
    DataTable dt = new DataTable();
    da.Fill(dt);

    if (dt.Rows.Count > 0)
    {
        Response.Redirect("https://www.google.co.th/");
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Sorry, wrong username.</p>\r\n");
#nullable restore
#line 42 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
    }
    conn.Close();

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Pages.LoginSqlModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Pages.LoginSqlModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Pages.LoginSqlModel>)PageContext?.ViewData;
        public Project.Pages.LoginSqlModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
