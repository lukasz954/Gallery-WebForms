<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Motorcycles.aspx.cs" Inherits="Gallery.Motorcycles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 600px;">
                <table style="width: 600px;">
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/19-softail-breakout-hero.jpg" OnClick="Unnamed1_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/3618.jpg" OnClick="Unnamed2_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/https___specials-images.forbesimg.com_imageserve_5c0aa5554bbe6f0f2aa19644_960x0.jpg" OnClick="Unnamed3_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/images.jpg" OnClick="Unnamed4_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/IMG_8125.jpg" OnClick="Unnamed5_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/indiant-ftr-1200-1540482461.jpg" OnClick="Unnamed6_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/protongts.jpg" OnClick="Unnamed7_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/SY125-10.png" OnClick="Unnamed8_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Motorcycles/thearsenale-nash-motorcycle-ko-chopper-nash-motorcycles_1024x1024.jpg" OnClick="Unnamed9_Click" />
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
