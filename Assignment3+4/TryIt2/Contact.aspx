<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TryIt2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <main aria-labelledby="title" style="padding-bottom: 20px">
    <h2 id="title" style="margin:25px">Natural Disaster Cases by State</h2>
    <div>
        <h4>
        <asp:Label runat="server" Text="Enter your state here:" style="margin:20px"></asp:Label><asp:TextBox runat="server" ID="StateBox" style="padding-right:20px"></asp:TextBox>
        <asp:Button runat="server" Text="Submit" OnClick="Unnamed5_Click" ID="EarthquakeButton"></asp:Button>
        </h4>
        

    
    </div>
    <p>
        <asp:Label runat="server" Text="Total Disasters:" ID="totalDisasters" Font-Bold="True" ForeColor="Black" style="margin:25px"></asp:Label><asp:Label runat="server" Text=" 0" ID="countLabel" Font-Bold="True" ForeColor="Red"></asp:Label>
        
    </p>
   
        <asp:Label runat="server" Text="Result" ID="OutputLabel" style="margin:25px"></asp:Label>
</main>
</asp:Content>
