<%@ Page Title="Our curriculum!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Curriculum.aspx.cs" Inherits="DrumsAcademy.WebForms.Curriculum.Curriculum" %>

<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit, Version=16.1.1.0, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e" %>
<asp:Content ID="CurriculumContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: this.Title %></h2>

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
                                Beginer
                            </button>
                        </Header>
                        <Content>
                            <ul class="list-unstyled">
                                <li>
                                    <p>Notes</p>
                                </li>
                                <li>
                                    <p>Basic hand and feet techniques</p>
                                </li>
                                <li>
                                    <p>Basic Rudiments</p>
                                </li>
                            </ul>
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane2">
                        <Header>
                            <button class="btn btn-margin">
                                Intermediate
                            </button>
                        </Header>
                        <Content>
                            <ul class="list-unstyled">
                                <li>
                                    <p>Songs</p>
                                </li>
                                <li>
                                    <p>Advanced rudiments</p>
                                </li>
                                <li>
                                    <p>Double base techniques</p>
                                </li>
                            </ul>
                        </Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane runat="server" CssClass="btn" ID="AccordionPane4">
                        <Header>
                            <button class="btn btn-margin">
                                Advanced
                            </button>
                        </Header>
                        <Content>
                            <ul class="list-unstyled">
                                <li>
                                    <p>Advanced songs</p>
                                </li>
                                <li>
                                    <p>Advanced hand and feet techniques</p>
                                </li>
                                <li>
                                    <p>Drum camps</p>
                                </li>
                            </ul>
                        </Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
