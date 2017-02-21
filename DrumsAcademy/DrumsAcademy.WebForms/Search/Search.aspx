<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="DrumsAcademy.WebForms.Search.Search" %>
<%@ Import Namespace="System.Web.DynamicData" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls.Expressions" %>
<%@ Import Namespace="System.Web.UI.WebControls.WebParts" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <ul class="nav">
        <li class="search">
            <asp:TextBox CssClass="input-sm" ID="SearchInputId" runat="server" />
        </li>
        <li class="search">
            <asp:DropDownList ID="SearchDropDownListId" CssClass="dropdown" runat="server">
                <asp:ListItem>
                    username
                </asp:ListItem>
                <asp:ListItem>
                    resource title
                </asp:ListItem>
            </asp:DropDownList>
        </li>
    </ul>
</asp:Content>
