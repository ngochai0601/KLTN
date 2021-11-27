<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhanDien.aspx.cs" Inherits="TraCuuDiem.NhanDien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="SS_NhanDien.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
        }
        .auto-style2 {
            margin-top: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <img src="https://sinhvien.hufi.edu.vn/Content/AConfig/images/sv_logo_dashboard.png"/>

            <h1 class="auto-style1">NHẬN DIỆN GƯƠNG MẶT</h1>
        </div>
        <div class="content">
            <center><img src="link" /><br />
            <input type="file" id="input" />
                <br />
            <input id="Button1" type="button" value="Nhận Diện" /></div></center>
            
        <div class="left">
            
            <img alt="" src="" style="height: 250px; width: 250px; margin-left: 84px; margin-top: 50px;" /></div>

        <div class="right">
            <h3 class="auto-style2">Thông tin sinh viên</h3>
            <p>MSSV:&nbsp;
                <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            </p>
            <p>Họ tên:
                <asp:Label ID="Label2" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            </p>
            <p>Giới tính:
                <asp:Label ID="Label3" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            </p>
            <p>Nơi sinh:
                <asp:Label ID="Label4" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            </p>
            <p>Lớp học:
                <asp:Label ID="Label5" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            </p>
            <p>Khóa học:
                <asp:Label ID="Label6" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            </p>
            <p>Bậc đào tạo:
                <asp:Label ID="Label7" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            </p>
            <p>Loại hình đào tạo:
                <asp:Label ID="Label8" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            </p>
            <p>Ngành:
                <asp:Label ID="Label9" runat="server" CssClass="auto-style1" Text="Label"></asp:Label>
            
            </p>
            <p>
            
            <input id="Button2" type="button" value="XEM KẾT QUẢ HỌC TẬP" /></p>
        </div>
    </form>
</body>
</html>
