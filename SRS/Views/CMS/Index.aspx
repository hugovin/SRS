<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        SRS Admin
    </h1>
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span2">
                <ul class="nav nav-pills nav-stacked">
                    <li class="active"><a href="/CMS">Home</a></li>
                    <li ><a href="/Rooms">Rooms</a></li>
                    <li ><a href="/Buildings">Buildings</a></li>
                    <li ><a href="/Devices">Devices</a></li>
                </ul>
            </div>
            <div class="span10">
                <div class="row span10">
                    <h2>
                        DashBoard</h2>
                </div>
                <div class="row span10">
                   
                    <div id="chart_div" style="width: 900px; height: 500px;"></div>

                    
                </div>
            </div>
            <div class="row span10">
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CustomJs" runat="server">
    <script src="../../Content/js/jquery-1.10.2.min.js" type="text/javascript""></script>
    <script src="../../Content/js/bootstrap.js" type="text/javascript""></script>
    <script src="../../Content/js/bootstrap-modal.js" type="text/javascript""></script>
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script type="text/javascript">
        google.load("visualization", "1", { packages: ["corechart"] });
        google.setOnLoadCallback(drawChart);
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
          ['Year', 'Room1', 'Room2','Room3',"Room4"],
          ['2004', 1000, 400, 200, 500],
          ['2005', 1170, 460, 466, 300],
          ['2006', 660, 1120, 568, 800],
          ['2007', 1030, 540, 240, 968]
        ]);

            var options = {
                title: 'Rooms Use',
                hAxis: { title: 'Meetings per room', titleTextStyle: { color: 'red'} }
            };

            var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));
            chart.draw(data, options);
        }
    </script>
</asp:Content>