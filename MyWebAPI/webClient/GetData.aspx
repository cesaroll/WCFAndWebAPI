<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetData.aspx.cs" Inherits="webClient.GetData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.2.3.min.js"></script>
    <script src="Scripts/jquery.unobtrusive-ajax.min.js"></script>
    
    <script type="text/javascript">

        $(document).ready(function() {

            $("#btnGetData").click(function() {
                
                //jQuery based ajax call
                //CORS installed and setup on WebService to make this works
                $.ajax({
                    type: "GET",
                    url: "http://localhost:47801/api/test",
                    success: function(data) {
                        console.log(data);
                    },
                    error: function() {
                        console.log('Error in Reading');
                    }
                });

            });

        });

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="button" id="btnGetData" value="GetData"/>
    </div>
    </form>
</body>
</html>
