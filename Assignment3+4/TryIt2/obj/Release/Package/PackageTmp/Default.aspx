<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"  style="padding: 20px;">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle"  style="padding-bottom: 20px;"> Enter Stemming input here:
             </h1>
            <p class="lead" style="padding-left: 200px">
                <asp:TextBox runat="server" ID="inputBox" MaxLength="100"
           TextMode="MultiLine" 
           Width="650px" Height="300"></asp:TextBox>
                
                  
                  <asp:Button runat="server" Text="Submit" OnClick="Unnamed1_Click"></asp:Button>
                   <asp:TextBox runat="server" ID="TextBox2" MaxLength="100"
TextMode="MultiLine" 
Width="650px" Height="300"></asp:TextBox>
             </p>
              <div>
    
            </div>
        </section>

    
    </main>

</asp:Content>
