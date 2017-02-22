<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddCategoryViewControl.ascx.cs" Inherits="DrumsAcademy.WebForms.UserControls.AddCategoryViewControl" %>
<%@ Import Namespace="System.Web.DynamicData" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls.Expressions" %>
<%@ Import Namespace="System.Web.UI.WebControls.WebParts" %>

<asp:TextBox Mode="Encode" ID="RoleLiteral" runat="server"/>
<asp:Button ID="RoleSenderID" OnClick="RoleSenderID_OnClick" runat="server"/>