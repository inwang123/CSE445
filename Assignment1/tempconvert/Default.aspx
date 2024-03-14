<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
  CodeBehind="Default.aspx.cs" Inherits="tempconvert._Default" %>

  <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main style="background-color:lightgrey;">
           <style>
            main {
                margin: 20px;
            }
            section{

                margin:20px;
            }
            h1{
                text-align:center;
            }
        </style>
        <p>
      <section class="row" aria-labelledby="aspnetTitle">

        <h1 id="aspnetTitle">Temperature Convert 😼</h1>


      </section>

      <div class="row">
        <section class="col-md-4" aria-labelledby="gettingStartedTitle">

          <div>
            <asp:TextBox ID="cBox" runat="server" OnTextChanged="cBox_TextChanged" ></asp:TextBox>
              <asp:Button ID="Button1" runat="server" Text="C to F" OnClick="CtoF" />
          </div>
          <asp:Label ID="c2fResult" runat="server" Text="Result"></asp:Label>
          <div>
            <asp:TextBox ID="fBox" runat="server"></asp:TextBox>
              <asp:Button ID="Button3" runat="server" Text="F to C" OnClick="FtoC" />
          </div>
          <asp:Label ID="f2cResult" runat="server" Text="Result"></asp:Label>

        </section>
        <section class="col-md-4" aria-labelledby="gettingStartedTitle">
            <asp:Image ID="Image1" runat="server" />
        </section>
      </div>


      <section class="row" aria-labelledby="aspnetTitle">

        <h1>Sort</h1>


      </section>

      <div class="row">
        <section class="col-md-4" aria-labelledby="gettingStartedTitle">

          <div>
            <asp:TextBox ID="sortBox" runat="server"></asp:TextBox>
          </div>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="sortItems" />
          <div>
            <asp:Label ID="errBox" runat="server" Text="Result"></asp:Label>
          </div>
        </section>
      </div>

    </main>

  </asp:Content>