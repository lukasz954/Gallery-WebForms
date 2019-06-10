<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="Gallery.WebForm1" %>
<asp:Content ID="Cars" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 600px;">
                <table style="width: 600px;">
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/34289_75.jpg" OnClick="Unnamed1_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Audi-R8-powłoka-ceramiczna-Ceramic-Pro-1024x683.jpg" OnClick="Unnamed2_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/auto-moto-spa-czyszczenie-samochodow-bydgoszcz.jpg" OnClick="Unnamed3_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/auto-spa-posejdon-slider-bg.png" OnClick="Unnamed4_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/auto3.png" OnClick="Unnamed5_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/images.jpg" OnClick="Unnamed6_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/lexus_lc500_1.1200.jpg" OnClick="Unnamed7_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/slide_1.jpg" OnClick="Unnamed8_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/z23867990Q,Warszawa-M20-GT.jpg" OnClick="Unnamed9_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td style="text-align:center;background-color:#4f5256;">
               
                <table style="width: 100%">
                    <tr>
                        <td>
                            <asp:Label class="title" ID="Label_Title" runat="server" Text="Tytuł"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image class="image-big-view" ID="CarBigView" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label class="description" ID="Label_Description" runat="server" Text="Opis"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton class="arrow" ID="ImageButton_Left" runat="server" ImageUrl="~/Img/arrowLeft.png" OnClick="ImageButton_Left_Click" />
                            <asp:ImageButton class="arrow" ID="ImageButton_Right" runat="server" ImageUrl="~/Img/arrowRight.png" OnClick="ImageButton_Right_Click" />
                        </td>
                    </tr>
                </table>
               
            </td>
        </tr>
    </table>
</asp:Content>
