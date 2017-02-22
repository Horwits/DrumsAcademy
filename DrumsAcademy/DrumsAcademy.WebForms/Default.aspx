<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DrumsAcademy.WebForms._Default" %>

<%@ Register TagPrefix="ucc" TagName="OurCurriculum" Src="/UserControls/OurCurriculamUserControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2 class="yellow">Welcome to</h2>
        <h1>DrumsAcademy</h1>
        <p class="lead">Community-based free learning system!</p>
        <p><a href="/About.aspx" class="btn btn-primary btn-lg">About us &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <ucc:OurCurriculum ID="OurCurriculumId" runat="server" />
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
