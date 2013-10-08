<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Rooms Admin
    </h1>
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span2">
                <ul class="nav nav-pills nav-stacked">
                    <li ><a href="/CMS">Home</a></li> 
                    <li class="active"><a href="/Rooms">Rooms</a></li>
                    <li ><a href="/Buildings">Buildings</a></li>
                    <li ><a href="/Devices">Devices</a></li>
                </ul>
            </div>
            <div class="span10">
                <div class="row span10">
                    <h2>
                        Filters</h2>
                    <div class="span10">
                        <input type="text" class="span4" id="txtRoomName" placeholder="Type Room Name…" />
                        <select class="span4">
                            <option>Country Name</option>
                            <option>Costa Rica</option>
                        </select>
                    </div>
                </div>
                <div class="row span10">
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>
                                    Room Name
                                </th>
                                <th>
                                    Country
                                </th>
                                <th>
                                    Building
                                </th>
                                <th>
                                    Actions
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    Tortuguero
                                </td>
                                <td>
                                    Costa Rica
                                </td>
                                <td>
                                    Neu1
                                </td>
                                <td>
                                    <i class="icon-edit"></i>&nbsp;|&nbsp; <i class="icon-remove"></i>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Samara
                                </td>
                                <td>
                                    Costa Rica
                                </td>
                                <td>
                                    Neu1
                                </td>
                                <td>
                                    <i class="icon-edit"></i>&nbsp;|&nbsp; <i class="icon-remove"></i>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tamarindo
                                </td>
                                <td>
                                    Costa Rica
                                </td>
                                <td>
                                    Neu1
                                </td>
                                <td>
                                    <i class="icon-edit"></i>&nbsp;|&nbsp; <i class="icon-remove"></i>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    

                    <a href="#myModal" role="button" class="btn btn-success" data-toggle="modal">Create A new Room</a>
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
