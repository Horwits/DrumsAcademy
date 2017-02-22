<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TeacherPanel.aspx.cs" Inherits="DrumsAcademy.WebForms.Teacher.TeacherPanel" %>

<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=16.1.1.0, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: this.Page.Title %></h1>
    <hr />
    <asp:UpdatePanel UpdateMode="Conditional"
        runat="server" class="panel">
        <ContentTemplate>
            <asp:Accordion ID="AdminAccordeonActionPaneId" CssClass="nav" runat="server"
                HeaderSelectedCssClass="btn-selected"
                FadeTransitions="true"
                TransitionDuration="100"
                FramesPerSecond="30"
                SuppressHeaderPostbacks="True">
                <Panes>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane1">
                        <Header>
                            <button class="btn btn-margin">
                                Add resource
                            </button>
                        </Header>
                        <Content>
                            <asp:ListView ID="ListView1" runat="server" ItemType="DrumsAcademy.Models.Resource"
                                SelectMethod="ListView1_GetData" InsertMethod="ListView1_InsertItem"
                                DeleteMethod="ListView1_DeleteItem" UpdateMethod="ListView1_UpdateItem"
                                InsertItemPosition="LastItem"
                                DataKeyNames="Id">
                                <LayoutTemplate>
                                    <table id="MainContent_GridViewCategories" class="table-responsive" style="border-collapse: collapse;">
                                        <tbody>
                                            <tr>
                                                <th scope="col">
                                                    <asp:LinkButton Text="Resource Name" runat="server" ID="LinkButtonSortByCategory" CommandName="Sort" CommandArgument="Name" />
                                                </th>
                                                <th scope="col">Action</th>
                                            </tr>
                                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                                            <tr>
                                                <td colspan="2">
                                                    <asp:DataPager runat="server" ID="DataPagerCategories" PageSize="5">
                                                        <Fields>
                                                            <asp:NumericPagerField />
                                                        </Fields>
                                                    </asp:DataPager>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td><%#: Item.Type.ToString() %></td>
                                        <td>
                                            <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Edit" CommandName="Edit" />
                                            <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Delete" CommandName="Delete" />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Title %>" />
                                        </td>
                                        <td>
                                            <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Save" CommandName="Update" />
                                            <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" />
                                        </td>
                                    </tr>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <tr>
                                        <td>
                                            <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Title %>" />
                                        </td>
                                        <td>
                                            <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Insert" CommandName="Insert" />
                                            <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Cancel" CommandName="Cancel" />
                                        </td>
                                    </tr>
                                </InsertItemTemplate>
                            </asp:ListView>
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane2">
                        <Header>
                            <button class="btn btn-margin">
                                Remove resource
                            </button>
                        </Header>
                        <Content>
                            Lorem ipsum dolor sit amet
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane4">
                        <Header>
                            <button class="btn btn-margin">
                                Edit resource
                            </button>
                        </Header>
                        <Content>
                            Lorem ipsum dolor sit amet
                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
