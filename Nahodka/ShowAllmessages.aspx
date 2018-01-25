<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ShowAllmessages.aspx.cs" Inherits="Nahodka.ShowAllmessages" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="BodyContent" runat="server">
 <h3>Message List</h3>
    <asp:Repeater ID="MessageRepeater" runat="server">
        <ItemTemplate>
            <HeaderTemplate>
            <table border="1">
                <tr>
                    <th>Message type</th>
                    <th>Name</th>
                    <th>Adress</th>
                    <th>Color</th>
                    <th>Type</th>
                    <th>Size</th>
                     <th>Breed</th>
                    <th>Description</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td> <%# Eval("MessageType") %></td>
                <td><%# Eval("Name") %> </td>
                <td><%# Eval("Adress") %></td>
                <td><%# Eval("Color") %></td>
                <td><%# Eval("Type") %></td>
                <td><%# Eval("Size") %></td>
                <td><%# Eval("Breed") %></td>
                <td><%# Eval("Description") %></td>

            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
