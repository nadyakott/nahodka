<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CompareMessages.ascx.cs" Inherits="Nahodka.CompareMessages1" %>
<%@ Import Namespace="InputOutputMessages" %>

    <h2 class="text-center">Compare Messages</h2>
    <div class="container">
        <div class="row">
        <div class="col-md-6">
            <div class="card">
    <div class="card-body">
    <h5 class="card-title">Message Lost Item</h5>
    <p class="card-text text-info">
        <% foreach (var item in InputOutputMessage.Input)
            { %>
        <%= item %>
        <%} %>
    </p>
  </div>
</div>
        </div>
            <div class="col-md-6">
<div class="card-body">
    <h5 class="card-title">Message Found Item</h5>
    <p class="card-text text-info">
        <% foreach (var item in InputOutputMessage.Output)
            { %>
        <%= item %>
        <%} %>
    </p>
  </div>
                </div>
            </div>
        <asp:Button ID="btn_compare" OnClick="btn_compare_Click" runat="server" Text="Match percent of messages " CssClass="btn btn-info" />
       <asp:Label runat="server" ID="lbl_comparePerc" CssClass="text-success" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    </div>