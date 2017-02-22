<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="DrumsAcademy.WebForms.About" %>
<%@ Import Namespace="System.Web.DynamicData" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls.Expressions" %>
<%@ Import Namespace="System.Web.UI.WebControls.WebParts" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container about-page-container">
        <h1>Drums Academy</h1>
        <br />
        is a site,
        <br />
            dedicated to provide community - based teaching with volunteer teachers.
        <br />
            We've designed a <a href="~/curriculum/curriculum.aspx" runat="server">curriculum</a> for you to learn.
        
    </div>
</asp:Content>
