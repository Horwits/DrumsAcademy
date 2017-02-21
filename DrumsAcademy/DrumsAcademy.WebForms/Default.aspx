<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DrumsAcademy.WebForms._Default" %>
<%@ Import Namespace="System.Web.DynamicData" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Web.UI.WebControls.Expressions" %>
<%@ Import Namespace="System.Web.UI.WebControls.WebParts" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2 class="yellow">Welcome to</h2>
        <h1>DrumsAcademy</h1>
        <p class="lead">Community-based free learning system!</p>
        <p><a href="/About.aspx" class="btn btn-primary btn-lg">About us &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>We have a plan</h2>
            <p>
                We have created a plan for the beginners and also every drummer who wants to learn something new.
            </p>
            <p>
                <a class="btn btn-default" href="~/Plan/Plan.aspx" runat="server">Check it out &raquo;</a>
            </p>
        </div>
        <div class="col-md-6">
            <h2>Just sign up</h2>
            <p>
                It's free!
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Sign up for free &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
