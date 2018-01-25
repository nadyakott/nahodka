<%@ Page Title="Add Message to find lost stuff" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="AddMessage.aspx.cs" Inherits="Nahodka.AddMessage" %>

<%@ Register TagPrefix="CompareControl" TagName="CompareTwoMessages" Src="~/CompareMessages.ascx" %>
<%@ Register TagPrefix="InfoBoxControl" TagName="InfoBoxShow" Src="~/InfoBox.ascx" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="BodyContent" runat="server">
   <%-- <h2><%: Title %>.</h2>--%>
          <InfoBoxControl:InfoBoxShow runat="server"/>
    <div class="container">
    <table class="col-md-6" border="0">
        <tr>
            <td>
                <%--<asp:DropDownList ID="DropDownListMessageType" runat="server"></asp:DropDownList>--%>
                <h3>Enter Lost Item</h3>
            </td>
        </tr>
        <tr>
            <td>
                  <asp:Label Text="NAME" runat="server"></asp:Label>
                   <asp:TextBox  runat="server" ID="txtbx_name" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="ADRESS" runat="server"></asp:Label>
                      <asp:TextBox  runat="server" ID="txtbx_adress" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="DATE" runat="server"></asp:Label>
                    <asp:TextBox  runat="server" ID="txtbx_date" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="TYPE" runat="server"></asp:Label>
                   <asp:TextBox  runat="server" ID="txtbx_type" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="COLOR" runat="server"></asp:Label>
                  <asp:TextBox  runat="server" ID="txtbx_color" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="SIZE" runat="server"></asp:Label>
                   <asp:TextBox  runat="server" ID="txtbx_size" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="BREED" runat="server"></asp:Label>
                   <asp:TextBox  runat="server" ID="txtbx_breed" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="DESCRIPTION" runat="server"></asp:Label>
                  <asp:TextBox  runat="server" ID="txtbx_descript" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="ButtonAdd" Onclick="ButtonAdd_Click" runat="server" Text="Add" Enabled="True" CssClass="btn btn-success" />
                <asp:Button ID="ButtonClear" OnClick="ButtonClear_Click" runat="server" Text="Clear" CssClass="btn btn-secondary" />
            </td>
        </tr>
    </table>
    <h3> Enter Found Item</h3>
    <table class="col-md-6 txt-center" border="0">
        <tr>
            <td>
                  <asp:Label Text="NAME" runat="server"></asp:Label>
                   <asp:TextBox  runat="server" ID="txtbx_fname" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="ADRESS" runat="server"></asp:Label>
                      <asp:TextBox  runat="server" ID="txtbx_fadress" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="DATE" runat="server"></asp:Label>
                    <asp:TextBox  runat="server" ID="txtbx_fdate" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="TYPE" runat="server"></asp:Label>
                   <asp:TextBox  runat="server" ID="txtbx_ftype" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="COLOR" runat="server"></asp:Label>
                  <asp:TextBox  runat="server" ID="txtbx_fcolor" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="SIZE" runat="server"></asp:Label>
                   <asp:TextBox  runat="server" ID="txtbx_fsize" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="BREED" runat="server"></asp:Label>
                   <asp:TextBox  runat="server" ID="txtbx_fbreed" />
            </td>
        </tr>
        <tr>
                <td>
                  <asp:Label Text="DESCRIPTION" runat="server"></asp:Label>
                  <asp:TextBox  runat="server" ID="txtbx_fdescr" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" Text="Add" Enabled="True" CssClass="btn btn-success" />
                 <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" CssClass="btn btn-secondary" />
            </td>
        </tr>
    </table>
        </div>
    <CompareControl:CompareTwoMessages ID="CompareMes" runat="server"/>
    </asp:Content>
