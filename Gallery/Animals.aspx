<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Animals.aspx.cs" Inherits="Gallery.Animals" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 600px;">
                <table style="width: 600px;">
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/2fgau1c20e61000.jpg" OnClick="Unnamed1_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/baby-animal-names.jpg" OnClick="Unnamed2_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/BlackPanther1910.jpg" OnClick="Unnamed3_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/category-thumbnail-mammals_0.jpg" OnClick="Unnamed4_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/elephanthero1.jpg" OnClick="Unnamed5_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/loggerhead-turtle.jpg" OnClick="Unnamed6_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/p04f5x5v.jpg" OnClick="Unnamed7_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/panama-animal-transport-plane.jpg" OnClick="Unnamed8_Click" />
                        </td>
                        <td class="cell-small-view">
                            <asp:ImageButton class="image-small-view" runat="server" ImageUrl="~/Img/Animals/TBY5IslL.jpeg" OnClick="Unnamed9_Click" />
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
