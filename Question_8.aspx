<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Question_8.aspx.cs" Inherits="Question_8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
     <p style="margin-left: 60px; width: 993px;" class="auto-style1">
           8. Describe .NET Exception Handling. What are the four keywords used to 
throw and handle exceptions? What is the base class of all exceptions? 
</p>
     <p style="margin-left: 60px; width: 993px;" class="auto-style1">
           a. In your web site create a custom exception. 
</p>
     <p style="margin-left: 60px; width: 993px;" class="auto-style1">
           b. Add an extra button to this page with the text “Exception”. When 
the user clicks on this button throw your custom exception. Be 
sure you also handle the exception properly. 
</p>
     <p style="margin-left: 60px; width: 993px;" class="auto-style1">
           c. Add another multi-line text box to this page to show the process 
through all four of the keywords that you described above. Also 
show the exception message. This need not be serialized as it will 
be generated each time you press the “Exception” button. 
</p>
     <p style="margin-left: 60px; width: 993px;" class="auto-style1">
           d. Add another multi-line text box to this page and copy your code 
into it. This should be serialized. 
e. Be sure to serialize/deserialize where indicated this additional 
information.
</p>
<p>
    <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span> &nbsp;<asp:Button ID="Button_view" runat="server" Height="26px" Text="View answer"  Width="97px" OnClick="Button_view_Click"  />
&nbsp;&nbsp;&nbsp;
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Height="28px" Text="View Exception" Width="98px" OnClick="Button3_Click"   />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
     <p>
    &nbsp;<asp:TextBox id="TextBox_1" TextMode="multiline" Columns="150" Rows="30" AutoPostBack="true"   cssclass="NoScroll" runat="server"  style="margin-left: 38px;OVERFLOW: hidden;" Height="427px" Width="950px" Visible="False" />
</p>
     <p>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="312px" TextMode="MultiLine" AutoPostBack="true"   cssclass="NoScroll" style="OVERFLOW: hidden;" Width="950px" Visible="False"></asp:TextBox>
     </p>
     <p>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button4" runat="server" Text="Raise Exception" OnClick="Button4_Click" Visible="False" Width="98px" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="TextBox4" runat="server" Height="65px"  TextMode="MultiLine" Visible="False" Width="803px" style="margin-right: 0px; margin-left: 0px;"></asp:TextBox>
         &nbsp;</p>
     <p>
         &nbsp;</p>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Rate the answer"></asp:Label>
&nbsp;&nbsp;
    
    <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True" Font-Size="Medium" Height="37px" style="margin-top: 0px" Width="105px"  AutoPostBack="True">
        <asp:ListItem Value="Blue">0</asp:ListItem>
        <asp:ListItem Value="Pink">1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem Selected="True">5</asp:ListItem>
    </asp:DropDownList>
   
    <br />
     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Grader&#39;s Comments<br />
    </strong>
    <asp:TextBox id="TextBox2" TextMode="multiline" Columns="15" Rows="5" cssclass="NoScroll" runat="server"  style="margin-left: 41px" Height="106px" Width="960px" Font-Italic="True" Font-Size="Medium" ForeColor="#FF3300" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
       <asp:Button ID="Button1" runat="server" Height="45px" OnClick="Button1_Click" Text="Previous Question" Width="126px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="Button2" runat="server" Height="42px" OnClick="Button2_Click" Text="Next Question" Width="128px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    

</asp:Content>


