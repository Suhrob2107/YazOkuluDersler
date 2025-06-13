<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YazOkuluDersler.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TxtAd" runat="server" Text="Ogrenci adi" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtSoyad" runat="server" Text="Ogrenci soyadi" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
             <br />
             <div>
                 <asp:Label for="TxtNumara" runat="server" Text="Ogrenci numara" style="font-weight: bold"></asp:Label>
                 <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
             <br />
             <div>
                 <asp:Label for="TxtSifre" runat="server" Text="Ogrenci sifre" style="font-weight: bold"></asp:Label>
                 <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
                         <br />
             <div>
                 <asp:Label for="TxtFoto" runat="server" Text="Ogrenci fotograf" style="font-weight: bold"></asp:Label>
                 <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
             </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info"/>
    </form>
</asp:Content>
 

<%--9. TextBoxlari olusturuyoruz--%>