<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="tempconvert.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title" style="color:white;"><%: Title %>.</h2>
        <h3 style="color:white;">This application lets you convert temperatures, since other google sites totally doesn't do that for you already</h3>
        <p style="color:white;">It also lets you sort numbers.</p>
    </main>
</asp:Content>
