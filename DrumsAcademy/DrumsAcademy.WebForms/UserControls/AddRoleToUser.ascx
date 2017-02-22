<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddRoleToUser.ascx.cs" Inherits="DrumsAcademy.WebForms.UserControls.AddRoleToUserControl" %>

<div class="col-md-12">
    <asp:ListView runat="server"
        ID="ListViewResources"
        ItemType="DrumsAcademy.Authentication.ApplicationUser"
        SelectMethod="On_GetAllUsers"
        GroupItemCount="3">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>

        <ItemTemplate>
            <div class="col-md-4">
                <h2><%#: Item.Email %></h2>
                <ul>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </ul>
                <%--<li>
                    <asp:HyperLink NavigateUrl='<%# string.Format("~/resource/details/resourcedetails.aspx?id={0}", Item.Id) %>' runat="server" Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Category) %>' />
                </li>--%>
            </div>
        </ItemTemplate>
        <EmptyDataTemplate>
            No books in this category.
                   
        </EmptyDataTemplate>
    </asp:ListView>

    <%--<h1>Email: $1$<asp:Literal runat="server" ID="LiteralSearchQuery"  Mode="Encode"/>#1#
        <asp:TextBox ID="LiteralSearchQuery" runat="server" />
        <asp:Button Text="Click" OnClick="OnClick" runat="server" />
    </h1>
    <asp:FormView runat="server" ID="FormView" ItemType="DrumsAcademy.Authentication.ApplicationUser">
        <HeaderTemplate>
            <h1><%#: Eval(this.User.UserName) %></h1>
        </HeaderTemplate>
        <ItemTemplate>
            <li>
                <p><%#: Eval(this.User.Email) %></p>
                <p><%#:Eval(this.User.Id)%></p>

                $1$<asp:HyperLink NavigateUrl='<%# string.Format("~/bookdetails.aspx?id={0}", Item.Id) %>' runat="server" ID="HyperLinkBook" Text='<%# string.Format(@"""{0}"" by <i>{1}</i>", Item.Title, Item.Author) %>' />
                (Category: <%#: Item.Category.Name %>)  #1#               
            </li>
        </ItemTemplate>
    </asp:FormView>--%>
</div>

