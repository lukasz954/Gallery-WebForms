<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Gallery.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header">
        <h1>Galeria wykonana na potrzeby przedmiotu  <span style="font-style: italic;"</span> "Nowoczesne technologie w aplikacjach internetowych" </h1>
        
        <h2>Łukasz Bartkowiak</h2>

        <h3>Informatyka stosowana rok 1 stopień II</h3>
        <p>Wybierz galerie</p>
   </div>
        <div class="option">
            <asp:ImageButton class="button-logo" ID="Anuimals" runat="server" ImageUrl="~/Img/Logo/21c92f647908affb908b588b486b87e8.jpg" OnClick="Anuimals_Click" /> 
            <asp:ImageButton class="button-logo" ID="Cars" runat="server" ImageUrl="~/Img/Logo/kisspng-the-mp-car-group-car-dealership-vehicle-auto-detai-car-logo-5acc63ad412f59.047531031523344301267.jpg" OnClick="Cars_Click" /> 
            <asp:ImageButton class="button-logo" ID="Motorcycles" runat="server" ImageUrl="~/Img/Logo/vintage-motorcycle-logo-template-vector-6187947.jpg" OnClick="Motorcycles_Click" /> 
        </div>

    
</asp:Content>
