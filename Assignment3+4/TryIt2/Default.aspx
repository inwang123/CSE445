<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"  style="padding: 20px;">
       <main aria-labelledby="title" runat="server">
                <main style="padding-left:12vw">
                    <asp:Button runat="server" Text="Service Directory" OnClick="Unnamed5_Click2"></asp:Button>
       <h1>Minigame Corner</h1>

      <h2 id="title" runat="server">Get a random Pokemon Here!!!!!</h2>
  
    
        <asp:Image runat="server" ImageUrl="~/img/pokeball.png" Height="200px" ID="PokeBall" ImageAlign="Middle"></asp:Image>



        <div>
            <h1>
                <asp:Button runat="server" Text="Catch!" OnClick="Unnamed3_Click" BackColor="White"></asp:Button>
            </h1>
            <h5>
                 <asp:Label runat="server" Text="STATS" ID="resultLabel"></asp:Label>
            </h5>
           
        </div>          

        <h3>Sudoku Minigame Here! >>></h3>
         
         <h7>
             <asp:Button runat="server" Text="Play Now" ID="SudokuButton" OnClick="SudokuButton_Click"> </asp:Button>

      
     
               <asp:RadioButton runat="server" Text="Easy" ID="RadioButton1" GroupName="Difficulty"></asp:RadioButton>
               <asp:RadioButton runat="server" Text="Medium" ID="RadioButton2" GroupName="Difficulty"></asp:RadioButton>
               <asp:RadioButton runat="server" Text="Hard" ID="RadioButton3" GroupName="Difficulty"></asp:RadioButton>


          </h7>
           
               
        <div>
        </div>
        <h7 style="margin:50px">

            --------------------------------------------------------------------------------------------------
        </h7>
       

        
     
        <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t1"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t2"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t3"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t4"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t5"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t6"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t7"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t8"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t9"></asp:TextBox>
      </div>
      
        <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t10"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t11"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t12"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t13"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t14"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t15"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t16"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t17"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t18"></asp:TextBox>
      </div>

      <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t19"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t20"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t21"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t22"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t23"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t24"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t25"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t26"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t27"></asp:TextBox>
      </div>

      <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t28"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t29"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t30"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t31"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t32"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t33"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t34"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t35"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t36"></asp:TextBox>
      </div>

      <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t37"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t38"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t39"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t40"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t41"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t42"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t43"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t44"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t45"></asp:TextBox>
      </div>

      <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t46"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t47"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t48"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t49"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t50"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t51"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t52"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t53"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t54"></asp:TextBox>
      </div>

      <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t55"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t56"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t57"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t58"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t59"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t60"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t61"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t62"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t63"></asp:TextBox>
      </div>

      <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t64"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t65"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t66"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t67"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t68"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t69"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t70"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t71"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t72"></asp:TextBox>
      </div>

      <div runat="server">
          <asp:TextBox runat="server" Columns="5" ID="t73"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t74"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t75"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t76"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t77"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t78"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t79"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t80"></asp:TextBox>
          <asp:TextBox runat="server" Columns="5" ID="t81"></asp:TextBox>
      </div>
 
          <div>
    
              <asp:Button runat="server" Text="Check" OnClick="Unnamed3_Click1"></asp:Button><asp:Button runat="server" Text="See Answer" ID="AnswerButton" OnClick="AnswerButton_Click"></asp:Button>

        


              <div>
                  <asp:Label runat="server" Text="Label" ID="resultHolder" ForeColor="#FFFFCC"></asp:Label>
              </div>

</div>
            </main>
</main>

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
