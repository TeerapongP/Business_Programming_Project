#pragma checksum "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ba57224a824865498ceaa964d021b51b88fb13e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba57224a824865498ceaa964d021b51b88fb13e", @"/Pages/LoginSql.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7dae7ff6714ef70766776d91b193080525975d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoginSql : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
  
    var email_login = Request.Form["email_login"];
    var pass_login = Request.Form["pass_login"];

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

    }
    catch (Exception ex)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>???????????????????????????????????????????????????????????????!!!</p>\r\n");
#nullable restore
#line 24 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
    }

    try
    {
        conn.Open();
        String sqlCmd = "SELECT * FROM sign_in where email='" + email_login + "' AND pass='" + pass_login + "'";
        MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);
        MySqlDataReader dataReader = cmd.ExecuteReader();

        if (dataReader.HasRows)
        {
            dataReader.Read();
            if (dataReader[0].ToString().Equals("admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <script>\r\n                    window.setTimeout(function () { window.location.href = \"./admin\" });\r\n                </script>\r\n");
#nullable restore
#line 41 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <script>\r\n                    window.setTimeout(function () { window.location.href = \"./Home\" });\r\n                </script>\r\n");
#nullable restore
#line 47 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>\r\n                alert(\"UserId & Password Is not correct Try again..!!\");\r\n                window.setTimeout(function () { window.location.href = \"./Index\" });\r\n            </script>\r\n");
#nullable restore
#line 55 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
        }

        conn.Close();

    }
    catch (Exception ex)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Error : ");
#nullable restore
#line 62 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
              Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 63 "E:\Business_Programming_Project\Project\Project\Pages\LoginSql.cshtml"
    }

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
