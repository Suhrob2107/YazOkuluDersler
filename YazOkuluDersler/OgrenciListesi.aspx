<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkuluDersler.OgrenciListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Ogrenci ID</th>
            <th>Ogrenci Adi</th>
            <th>Ogrenci Soyadi</th>
            <th>Ogrenci Numarasi</th>
            <th>Ogrenci Fotograf</th>
            <th>Ogrenci Sifresi</th>
            <th>Ogrenci Bakiye</th>
            <th>Islemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("AD") %></td>
                        <td><%# Eval("SoyaD") %></td>
                        <td><%# Eval("Numara") %></td>
                        <td><%# Eval("Fotograf") %></td>
                        <td><%# Eval("Sifre") %></td>
                        <td><%# Eval("Bakiye") %></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciSil.aspx?OgrId=" + Eval("ID") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OgrId=" + Eval("ID") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Guncelle</asp:HyperLink>
                        </td>
                    </tr>
                    </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

<%--10.OgrenciListesi.Aspx olusturduk ve master page ten buraya yonlendirdik
    table olusturucaz--%>