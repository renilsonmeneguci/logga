﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using ErrorLog.Core;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Logga/Index.cshtml")]
    public partial class _Views_Logga_Index_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<Logga.Entities.LoggaEntry>>
    {
        public _Views_Logga_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Logga\Index.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\n\n<!DOCTYPE html>\n<html>\n<head>\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(">\n    <title>Hi, I\'m Logga and i\'m your Friend</title>\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"https://cdn.datatables.net/r/bs-3.3.5/jq-2.1.4,dt-1.10.8/datatables.min.cs" +
"s\"");

WriteLiteral(" />\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css\"");

WriteLiteral(">\n    <script");

WriteLiteral(" src=\"https://code.jquery.com/jquery-2.2.3.min.js\"");

WriteLiteral("></script>\n    <script");

WriteLiteral(" src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js\"");

WriteLiteral("></script>\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"https://cdn.datatables.net/r/bs-3.3.5/jqc-1.11.3,dt-1.10.8/datatables.min.j" +
"s\"");

WriteLiteral("></script>\n</head>\n<body>\n    <div");

WriteLiteral(" class=\"navbar navbar-default navbar-fixed-top\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\".navbar-collapse\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\n                </button>\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Logga\Index.cshtml"
           Write(Html.ActionLink("Logga", "Index", "Logga", new { area = "" }, new { @class = "navbar-brand" }));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n        </div>\n    </div>\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\n        <br /><br /><br /><br />\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\Logga\Index.cshtml"
       Write(Html.ActionLink("Create Test Error", "CreateError"));

            
            #line default
            #line hidden
WriteLiteral("\n        </div>\n        <br />\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\n            <table");

WriteLiteral(" class=\"table table-striped table-bordered\"");

WriteLiteral(">\n                <thead>\n                    <tr>\n                        <th>\n");

WriteLiteral("                            ");

            
            #line 43 "..\..\Views\Logga\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.DateError));

            
            #line default
            #line hidden
WriteLiteral("\n                        </th>\n                        <th>\n");

WriteLiteral("                            ");

            
            #line 46 "..\..\Views\Logga\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Source));

            
            #line default
            #line hidden
WriteLiteral("\n                        </th>\n                        <th>\n");

WriteLiteral("                            ");

            
            #line 49 "..\..\Views\Logga\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Target));

            
            #line default
            #line hidden
WriteLiteral("\n                        </th>\n                        <th>\n");

WriteLiteral("                            ");

            
            #line 52 "..\..\Views\Logga\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Type));

            
            #line default
            #line hidden
WriteLiteral("\n                        </th>\n                        <th>\n");

WriteLiteral("                            ");

            
            #line 55 "..\..\Views\Logga\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.User));

            
            #line default
            #line hidden
WriteLiteral("\n                        </th>\n                        <th>\n");

WriteLiteral("                            ");

            
            #line 58 "..\..\Views\Logga\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Host));

            
            #line default
            #line hidden
WriteLiteral("\n                        </th>\n                        <th></th>\n                " +
"    </tr>\n                </thead>\n                <tbody>\n");

            
            #line 64 "..\..\Views\Logga\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Logga\Index.cshtml"
                     foreach (var item in Model)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\n                            <td>\n");

WriteLiteral("                                ");

            
            #line 68 "..\..\Views\Logga\Index.cshtml"
                           Write(item.DateError);

            
            #line default
            #line hidden
WriteLiteral("\n                            </td>\n                            <td>\n");

WriteLiteral("                                ");

            
            #line 71 "..\..\Views\Logga\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Source));

            
            #line default
            #line hidden
WriteLiteral("\n                            </td>\n                            <td>\n");

WriteLiteral("                                ");

            
            #line 74 "..\..\Views\Logga\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Target));

            
            #line default
            #line hidden
WriteLiteral("\n                            </td>\n                            <td>\n");

WriteLiteral("                                ");

            
            #line 77 "..\..\Views\Logga\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Type));

            
            #line default
            #line hidden
WriteLiteral("\n                            </td>\n                            <td>\n");

WriteLiteral("                                ");

            
            #line 80 "..\..\Views\Logga\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.User));

            
            #line default
            #line hidden
WriteLiteral("\n                            </td>\n                            <td>\n");

WriteLiteral("                                ");

            
            #line 83 "..\..\Views\Logga\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Host));

            
            #line default
            #line hidden
WriteLiteral("\n                            </td>\n                            <td>\n");

WriteLiteral("                                ");

            
            #line 86 "..\..\Views\Logga\Index.cshtml"
                           Write(Html.ActionLink("Details", "Details", new { id = item.LoggaEntryId }, new { @class = "btn default btn-xs" }));

            
            #line default
            #line hidden
WriteLiteral("\n                            </td>\n                        </tr>\n");

            
            #line 89 "..\..\Views\Logga\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral(@"                </tbody>
            </table>
        </div>

        <script>
            jQuery(document).ready(function () {
                $('table').DataTable();
            });
        </script>
        <hr />
        <footer>
            <p>&copy; ");

            
            #line 101 "..\..\Views\Logga\Index.cshtml"
                 Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" - My ASP.NET Application</p>\n        </footer>\n    </div>\n</body>\n</html>\n");

        }
    }
}
#pragma warning restore 1591
