<%@ Page Title="ResourceDetails" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResourceDetails.aspx.cs" Inherits="DrumsAcademy.WebForms.Resource.Details.ResourceDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: this.Page.Title %></h1>
    <asp:FormView runat="server" ID="FormViewBookDetails" ItemType="DrumsAcademy.Models.Resource" CssClass="container" SelectMethod="On_GetResource">
        <ItemTemplate>
            <header>
                <h1><%#: Item.Title %></h1>
                <p><i>Level: <%#: Item.Level %></i></p>
                <p><i>Resource Category: <%#: Item.Category.Type %></i></p>
                <p>
                    <i>Web site: 
                    <a href="<%#: Item.Url %>">See here</a></i>
                </p>
            </header>
            <div class="row">
                <div class="center-text">
                    <h2><%#: Item.Description %></h2>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>

    <div class="back-link">
        <a href="/resource/resources.aspx">Back to resources</a>
    </div>
</asp:Content>
