<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TeacherPanel.aspx.cs" Inherits="DrumsAcademy.WebForms.Teacher.TeacherPanel" %>
<%@ Import Namespace="System.Web.DynamicData" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls.Expressions" %>
<%@ Import Namespace="System.Web.UI.WebControls.WebParts" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <ul class="ul-actions-menu row nav-tabs">
        <li class="list-unstyled"><a href="#" runat="server">add resource</a></li>
        <li class="list-unstyled"><a href="#" runat="server">create resource</a></li>
        <li class="list-unstyled"><a href="#" runat="server">delete resource</a></li>
    </ul>
</asp:Content>
