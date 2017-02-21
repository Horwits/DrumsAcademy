<%@ Page Title="Resources" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resources.aspx.cs" Inherits="DrumsAcademy.WebForms.Resource.Resources" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: this.Page.Title %></h1>

    <asp:ListView runat="server"
        ID="ListViewResources"
        ItemType="DrumsAcademy.Models.Resource"
        SelectMethod="ListViewResources_GetData"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>

        <ItemTemplate>
            <div class="col-md-4">
                <h2><%#: Item.Title %></h2>
                <ul>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </ul>
                <li>
                    <asp:HyperLink NavigateUrl='<%# string.Format("~/resource/details/resourcedetails.aspx?id={0}", Item.Id) %>' runat="server" Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Category) %>' />
                </li>
            </div>
        </ItemTemplate>
        <EmptyDataTemplate>
            No books in this category.
                   
        </EmptyDataTemplate>
    </asp:ListView>

</asp:Content>
