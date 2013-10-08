<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Devices Admin
    </h1>
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span2">
                <ul class="nav nav-pills nav-stacked">
                    <li ><a href="/CMS">Home</a></li> 
                    <li ><a href="/Rooms">Rooms</a></li>
                    <li ><a href="/Buildings">Buildings</a></li>
                    <li class="active"><a href="/Devices">Devices</a></li>
                </ul>
            </div>
            <div class="span10">
                <div class="row span10">
                    <h2>
                        Filters</h2>
                    <div class="span10">
                        <input type="text" class="span4" id="txtRoomName" placeholder="Type Serial#…" />
                        <select class="span4">
                            <option>Device Type</option>
                            <option>Video</option>
                            <option>Audio</option>
                            <option>Monitor</option>
                        </select>
                    </div>
                </div>
                <div class="row span10">
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>
                                    Serial#
                                </th>
                                <th>
                                    Description
                                </th>
                                <th>
                                    Location
                                </th>
                                <th>
                                    Actions
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    123456789
                                </td>
                                <td>
                                    Monitor
                                </td>
                                <td>
                                    Room#1
                                </td>
                                <td>
                                    <i class="icon-edit"></i>&nbsp;|&nbsp; <i class="icon-remove"></i>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    123456789
                                </td>
                                <td>
                                    Web Cam
                                </td>
                                <td>
                                    Room#2
                                </td>
                                <td>
                                    <i class="icon-edit"></i>&nbsp;|&nbsp; <i class="icon-remove"></i>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    45647897198
                                </td>
                                <td>
                                    Cool Monitor
                                </td>
                                <td>
                                    Room#3
                                </td>
                                <td>
                                    <i class="icon-edit"></i>&nbsp;|&nbsp; <i class="icon-remove"></i>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    

                    <a href="#myModal" role="button" class="btn btn-success" data-toggle="modal">Add Device</a>
                </div>
            </div>
            <div class="row span10">
            </div>
        </div>
    </div>

    <div id="myModal" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
        aria-hidden="true">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                ×</button>
            <h3 id="myModalLabel">
                Modal header</h3>
        </div>
        <div class="modal-body">
            <p>
                One fine body…</p>
        </div>
        <div class="modal-footer">
            <button class="btn" data-dismiss="modal" aria-hidden="true">
                Close</button>
            <button class="btn btn-primary">
                Save changes</button>
        </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CustomJs" runat="server">
    <script src="../../Content/js/jquery-1.10.2.min.js" type="text/javascript""></script>
    <script src="../../Content/js/bootstrap.js" type="text/javascript""></script>
    <script src="../../Content/js/bootstrap-modal.js" type="text/javascript""></script>
</asp:Content>