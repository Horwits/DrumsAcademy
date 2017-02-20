<%@ Page Title="Admin Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="DrumsAcademy.WebForms.Admin.AdminPanel" %>

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
                                Add role to user
                            </button>
                        </Header>
                        <Content>
                            Lorem ipsum dolor sit amet
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane2">
                        <Header>
                            <button class="btn btn-margin">
                                Remove role from user
                            </button>
                        </Header>
                        <Content>
                            Lorem ipsum dolor sit amet
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane3">
                        <Header>
                            <button class="btn btn-margin">
                                Add category
                            </button>
                        </Header>
                        <Content>
                            Lorem ipsum dolor sit amet
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane4">
                        <Header>
                            <button class="btn btn-margin">
                                Edit category
                            </button>
                        </Header>
                        <Content>
                            Lorem ipsum dolor sit amet
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane5">
                        <Header>
                            <button class="btn btn-margin">
                                Remove category
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
