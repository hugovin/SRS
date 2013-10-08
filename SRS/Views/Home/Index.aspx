<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../../Content/fullcalendar/fullcalendar.css" media="screen" rel="stylesheet" type="text/css">
    <link href="../../Content/fullcalendar/fullcalendar.print.css" media="screen" rel="stylesheet" type="text/css">
    <style>

	#calendar {
		width: 900px;
		margin: 0 auto;
		}

</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1>My Reservations</h1>
    <div class="container-fluid">
        <div class="row-fluid">
            
            <div class="span12">
                <div class="row span12">
                    <h2>
                        Filters</h2>
                    <div class="span12">
                        <select class="span3">
                            <option>Country Name</option>
                            <option>Costa Rica</option>
                        </select>
                        <select class="span3">
                            <option>Building Name</option>
                            <option>Neu1</option>
                        </select>
                        <input type="text" class="span2" id="txtRoomName" placeholder="Capacity" />
                        <select class="span3">
                            <option>Available Room</option>
                            <option>Room1</option>
                            <option>Room2</option>
                            <option>Room3</option>
                        </select>
                    </div>
                </div>
                <div class="row span12"></div>
                <hr />
                <div class="row span12">                
                    <div id='calendar'></div>

                  
                </div>
            </div>
            <div class="row span10">
            </div>
        </div>
    </div>


</asp:Content>

<asp:Content ID="Js" ContentPlaceHolderID="CustomJs" runat="server">
<script src="<%: Url.Content("~/Content/lib/jquery.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Content/lib/jquery-ui.custom.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Content/fullcalendar/fullcalendar.min.js") %>" type="text/javascript"></script>

    <script>
        $(document).ready(function () {

            var date = new Date();
            var d = date.getDate();
            var m = date.getMonth();
            var y = date.getFullYear();

            var calendar = $('#calendar').fullCalendar({
                header: {
                    left: 'prev,next today',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                selectable: true,
                selectHelper: true,
                select: function (start, end, allDay) {
                    var title = prompt('Event Title:');
                    if (title) {
                        calendar.fullCalendar('renderEvent',
						{
						    title: title,
						    start: start,
						    end: end,
						    allDay: allDay
						},
						true // make the event "stick"
					);
                    }
                    calendar.fullCalendar('unselect');
                },
                editable: true,
                events: [
				{
				    title: 'All Day Event',
				    start: new Date(y, m, 1)
				},
				{
				    title: 'Long Event',
				    start: new Date(y, m, d - 5),
				    end: new Date(y, m, d - 2)
				},
				{
				    id: 999,
				    title: 'Repeating Event',
				    start: new Date(y, m, d - 3, 16, 0),
				    allDay: false
				},
				{
				    id: 999,
				    title: 'Repeating Event',
				    start: new Date(y, m, d + 4, 16, 0),
				    allDay: false
				},
				{
				    title: 'Meeting',
				    start: new Date(y, m, d, 10, 30),
				    allDay: false
				},
				{
				    title: 'Lunch',
				    start: new Date(y, m, d, 12, 0),
				    end: new Date(y, m, d, 14, 0),
				    allDay: false
				},
				{
				    title: 'Birthday Party',
				    start: new Date(y, m, d + 1, 19, 0),
				    end: new Date(y, m, d + 1, 22, 30),
				    allDay: false
				},
				{
				    title: 'Click for Google',
				    start: new Date(y, m, 28),
				    end: new Date(y, m, 29),
				    url: 'http://google.com/'
				}
			]
            });

        });
    </script>
</asp:Content>
