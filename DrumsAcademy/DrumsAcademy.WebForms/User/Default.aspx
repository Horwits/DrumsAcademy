<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DrumsAcademy.WebForms.User.Default" %>
<%@ Import Namespace="System.Web.DynamicData" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls.Expressions" %>
<%@ Import Namespace="System.Web.UI.WebControls.WebParts" %>

<%@ Register TagPrefix="ucc" TagName="OurCurriculum" Src="/UserControls/OurCurriculamUserControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron h-user">
        <h2 class="yellow">Welcome to</h2>
        <h1>DrumsAcademy</h1>
    </div>
    
    <div class="col-lg-12">
        <ucc:OurCurriculum ID="OurCurriculumId" runat="server"/>
    </div>
</asp:Content>
