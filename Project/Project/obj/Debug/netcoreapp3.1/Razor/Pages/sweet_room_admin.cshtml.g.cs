#pragma checksum "E:\Business_Programming_Project\Project\Project\Pages\sweet_room_admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06f0bc3b832c1f3da4a84319382b11b84226fdf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.Pages.Pages_sweet_room_admin), @"mvc.1.0.razor-page", @"/Pages/sweet_room_admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f0bc3b832c1f3da4a84319382b11b84226fdf9", @"/Pages/sweet_room_admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7dae7ff6714ef70766776d91b193080525975d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_sweet_room_admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("user_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/normal_admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/sweet_room_admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/suit_room_admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <script>
        $(document).ready(function () {

            $(""#user_dialog"").dialog({
                autoOpen: false,
                width: 400
            });
            //$('#add') : ??????????????????????????????????????????????????? html element ??????????????? id ????????? add
            //$('#add').click( : ????????????????????? ??????????????? event ??????????????? click ?????????????????? html element ??????????????? id ????????? add
            $('#add').click(function () {
                //????????????????????????????????????????????? insert
                $('#user_dialog').attr('title', 'Edit Data');
                $('#action').val('insert');
                $('#form_action').val('Insert');
                $('#user_form')[0].reset();
                $('#form_action').attr('disabled', false);
                $(""#user_dialog"").dialog('open');//html element ??????????????? id ???????????? user_dialog ???????????????????????? dialog ???????????????
            });
            // ?????????????????? submit (????????????????????????????????? insert/update) ?????? user_form
            $('#user_form').on('submit', function (event) {
                event.preventDefault();
                $('");
            WriteLiteral(@"#form_action').attr('disabled', 'disabled');
                var form_data = $(this).serialize();
                $.ajax({
                    url: ""./sweet_actions"",
                    method: ""POST"",
                    data: form_data,
                    success: function (data) {
                        $('#user_dialog').dialog('close');
                        alert('?????????????????????????????????????????????????????????????????????')

                        $('#form_action').attr('disabled', false);
                    }
                });
            });



            // #delete_confirmation' ????????????????????? dialog ???????????????????????????????????????????????????????????????????????????
            $('#delete_confirmation').dialog({
                autoOpen: false,
                modal: true,
                buttons: {
                    Ok: function () {
                        var id = $(this).data('id'); //?????????????????????????????????????????? id ????????? data ????????? $('#delete_confirmation')
                        var action = 'delete'; //????????????????????????????????? action ???????????? delete ??????????????? server (actions) ???");
            WriteLiteral(@"???????????????????????????????????????????????? delete
                        $.ajax({
                            url: ""./sweet_actions"",
                            method: ""POST"",
                            headers: { ""RequestVerificationToken"": $('input[name=""__RequestVerificationToken""]').val() },
                            data: { id: id, action: action },
                            success: function (data) {
                                alert('Delete success');
                                $('#delete_confirmation').dialog('close');

                            },
                            error: function (errMsg) {
                                alert('Delete error');
                                console.log(errMsg);
                            }
                        });


                    },
                    Cancel: function () { $(this).dialog('close'); }
                }
            });

            //??????????????? event ????????? click ?????????????????????????????? delete (??????????????????????????????)
            $(document).on(");
            WriteLiteral(@"'click', '.delete', function () {
                var id = $(this).attr(""id"");
                $('#delete_confirmation').data('id', id);//????????????????????????????????????????????? id ?????? #delete_confirmation??????????????????????????? ?????????????????? id ????????????????????????????????????????????????
                $('#delete_confirmation').dialog('open');//???????????? #delete_confirmation ??????????????????
            });

            //??????????????? event ????????? click ?????????????????????????????? edit (??????????????????????????????) [??????????????????????????? html element ??????????????? class ???????????? edit]
            $(document).on('click', '.edit', function () {
                var id = $(this).attr(""id"");
                $('#form_action').val('?????????????????????????????????'); //??????????????????????????????????????????????????????????????????????????? update ???????????????????????????????????? user ?????????
                $('#hidden_id').val(id); //???????????????????????? id ??????????????????????????? form ????????????
                $('#action').val('update'); //????????????????????????????????????????????? update
                $('#user_dialog').dialog('open'); //??????????????? user_dialog ??????????????????
                //??????????????? select ????????? customerId ??????????????????????????????????????????????????? form ???????????? update
                var action = 'fetch_single';
         ");
            WriteLiteral(@"       $.ajax({
                    url: ""./sweet_actions"",
                    headers: { ""RequestVerificationToken"": $('input[name=""__RequestVerificationToken""]').val() },
                    method: ""POST"",
                    data: { id: id, action: action },
                    dataType: ""json"",
                    success: function (data) {
                        $('#names_customer').val(data[0].CustomerName);
                        $('#lastname_customer').val(data[0].CustomerLastName);
                        $('#id_card').val(data[0].CustomerIDCard);
                        $('#telephone_number').val(data[0].CustomerPhoneNumber);
                        $('#current_address_').val(data[0].CustomerAddress);
                        $('#blood_type').val(data[0].CustomerBloodType);
                        $('#congenitals_disease').val(data[0].CongenitalDisease);
                        $('#lease_').val(data[0].BookingDate);
                    },
                    error: function (jqXHR");
            WriteLiteral(@", text, errorThrown) {
                        console.log(jqXHR.responseText);
                    },
                });

            });

        });

        //???????????? json ???????????? html table
        function CreateTableFromJSON(myBooks) {


            // EXTRACT VALUE FOR HTML HEADER.
            // ('Book ID', 'Book Name', 'Category' and 'Price')
            var col = [];
            for (var i = 0; i < myBooks.length; i++) {
                for (var key in myBooks[i]) {
                    if (col.indexOf(key) === -1) {
                        col.push(key);
                    }
                }
            }

            // CREATE DYNAMIC TABLE.
            var table = document.createElement(""table"");

            // CREATE HTML TABLE HEADER ROW USING THE EXTRACTED HEADERS ABOVE.

            var tr = table.insertRow(-1);                   // TABLE ROW.

            for (var i = 0; i < col.length; i++) {
                var th = document.createElement(""th"");      // TABLE ");
            WriteLiteral(@"HEADER.
                th.innerHTML = col[i];
                tr.appendChild(th);
            }

            var edit_header = document.createElement(""th"");      // TABLE HEADER.
            edit_header.innerHTML = ""?????????????????????????????????"";
            tr.appendChild(edit_header);

            var delete_header = document.createElement(""th"");      // TABLE HEADER.
            delete_header.innerHTML = ""????????????????????????"";
            tr.appendChild(delete_header);


            // ADD JSON DATA TO THE TABLE AS ROWS.
            for (var i = 0; i < myBooks.length; i++) {

                tr = table.insertRow(-1);

                for (var j = 0; j < col.length; j++) {
                    var tabCell = tr.insertCell(-1);
                    tabCell.innerHTML = myBooks[i][col[j]];
                }

                var id = myBooks[i][col[0]];
                //??????????????????????????? edit
                var tabCell = tr.insertCell(-1);
                tabCell.innerHTML = '<button type=""button"" name=""edit"" class=""btn");
            WriteLiteral(@" btn-primary btn-xs edit"" id=""' + id + '"">Edit</button>';
                //??????????????????????????? delete
                tabCell = tr.insertCell(-1);
                tabCell.innerHTML = '<button type=""button"" name=""delete"" class=""btn btn-danger btn-xs delete"" id=""' + id + '"">Delete</button>';


            }

            return table;
        }


        function searchCustomers() {
            var customer_name = $(""#customer_name"").val();
            //????????? input ???????????? customer_country ????????????????????????????????????????????? ?????????????????? country
            $.ajax({
                type: ""POST"",
                headers: { ""RequestVerificationToken"": $('input[name=""__RequestVerificationToken""]').val() },
                url: ""./sweet_actions"",
                data: { customers_name: customer_name, action: ""select"" },
                dataType: ""json"",
                success: function (data) {

                    var table = CreateTableFromJSON(data);//??????????????? html ???????????? json
                    var divContainer = $(""#result""); //");
            WriteLiteral(@" ?????????????????????????????? html element ???????????? ???????????? data
                    divContainer.addClass(""table table-striped"");//??????????????? class (bootstrap class) (????????????????????? style)
                    divContainer.html(table); //??????????????????????????????????????????????????????????????? ????????????????????? ?????????????????? table
                    //$(""#showData"").html(table);

                },
                error: function (errMsg) {
                    alert(""????????????????????????????????????????????????????????????????????????????????? server"");
                    console.log(errMsg);
                }
            });


        }
    </script>

    <div id=""user_dialog"" title=""Edit Data"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f0bc3b832c1f3da4a84319382b11b84226fdf915353", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label>Enter Customer name</label>
                <input type=""text"" name=""names_customer"" id=""names_customer"" class=""form-control"" />
            </div>
            <div class=""form-group"">
                <label>Enter Customer lastname</label>
                <input type=""text"" name=""lastname_customer"" id=""lastname_customer"" class=""form-control"" />
            </div>

            <div class=""form-group"">
                <label>Enter ID Card </label>
                <input type=""text"" name=""id_card"" id=""id_card"" class=""form-control"" />
            </div>

            <div class=""form-group"">
                <label>Enter Phone Number</label>
                <input type=""text"" name=""telephone_number"" id=""telephone_number"" class=""form-control"" />
            </div>

            <div class=""form-group"">
                <label>Enter Current Address</label>
                <input type=""text"" name=""current_address_"" id=""current_address_"" c");
                WriteLiteral(@"lass=""form-control"" />
            </div>

            <div class=""form-group"">
                <label>Enter Blood Type</label>
                <input type=""text"" name=""blood_type"" id=""blood_type"" class=""form-control"" />
            </div>

            <div class=""form-group"">
                <label>Enter Congenitals Disease</label>
                <input type=""text"" name=""congenitals_disease"" id=""congenitals_disease"" class=""form-control"" />
            </div>

            <div class=""form-group"">
                <label>Enter Date</label>
                <input type=""date"" name=""lease_"" id=""lease_"" class=""form-control"" />
            </div>

            <div class=""form-group"">
                <input type=""hidden"" name=""action"" id=""action"" value=""insert"" />
                <input type=""hidden"" name=""hidden_id"" id=""hidden_id"" />
                <input type=""submit"" name=""form_action"" id=""form_action"" class=""btn btn-info"" value=""Insert"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div id=\"delete_confirmation\" title=\"Confirmation\">\r\n        <p>Are you sure you want to Delete this data?</p>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f0bc3b832c1f3da4a84319382b11b84226fdf919217", async() => {
                WriteLiteral(@"
        <header>
            <nav class=""navbar fixed-top navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3"">
                <div class=""container float-left"">
                    <a class=""navbar-brand "">
                        <img src=""/picture/icon.jpg"" width=""30"" height=""30"" class=""d-inline-block align-top""");
                BeginWriteAttribute("alt", " alt=\"", 11452, "\"", 11458, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        Gloucester Hotel
                    </a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                            aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                        <ul class=""navbar-nav flex-grow-1"">
                            <li class=""nav-item"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f0bc3b832c1f3da4a84319382b11b84226fdf920675", async() => {
                    WriteLiteral("Normal Room");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f0bc3b832c1f3da4a84319382b11b84226fdf922317", async() => {
                    WriteLiteral("Sweet Room");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f0bc3b832c1f3da4a84319382b11b84226fdf923958", async() => {
                    WriteLiteral("Suit Room");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f0bc3b832c1f3da4a84319382b11b84226fdf925616", async() => {
                    WriteLiteral("\r\n                    ");
#nullable restore
#line 282 "E:\Business_Programming_Project\Project\Project\Pages\sweet_room_admin.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    <input type=\"text\" id=\"customer_name\" name=\"customer_name\"");
                    BeginWriteAttribute("value", " value=\"", 12889, "\"", 12897, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control mr-sm-2\" placeholder=\"Search Name\">\r\n                    <button type=\"button\" onclick=\"searchCustomers()\" class=\"btn btn-outline-success my-2 my-sm-0\">Search</button>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </nav>\r\n        </header>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br />\r\n    <p style=\"color:white;\" id=\"result\"></p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Pages.sweet_roomModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Pages.sweet_roomModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Pages.sweet_roomModel>)PageContext?.ViewData;
        public Project.Pages.sweet_roomModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
