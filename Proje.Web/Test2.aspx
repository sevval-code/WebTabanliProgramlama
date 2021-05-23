<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Test2.aspx.cs" Inherits="Proje.Web.Test2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        LinQ Sorguları</p>
<br />
    <asp:ListBox ID="lst" runat="server" OnSelectedIndexChanged="lst_SelectedIndexChanged"></asp:ListBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    <asp:Button ID="Button2" runat="server" Text="EntityFramewrok ile Getir" onClick="Button2_Click"/>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
