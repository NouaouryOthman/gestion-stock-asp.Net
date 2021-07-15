<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Tache.aspx.cs" Inherits="Controle_ASP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
                <tr>
                    <td>
                        <asp:Label ID="lbIdTache" runat="server" Text="Id : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbIdTache" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbDescriptionTache" runat="server" Text="Description : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbDescriptionTache" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbEmployeTache" runat="server" Text="Employe : "></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlEmployeTache" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                       <pre>
                       <asp:Button ID="btMAJ" runat="server" Text="MaJ" OnClick="btMAJ_Click"/>              
                       <asp:Button ID="btAjouter" runat="server" Text="Ajouter" OnClick="btAjouter_Click" />                 <asp:Button ID="btSupprimer" runat="server" Text="Supprimer" OnClick="btSupprimer_Click"/>               
                       <asp:Button ID="btRecherche" runat="server" Text="Recherche" OnClick="btRecherche_Click"/>
                       <asp:Button ID="BtSuppression" runat="server" Text="Suppression"/>
                       </pre>                      
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" style="align-self:center">
                        <asp:GridView ID="gVTaches" runat="server" GridLines="Horizontal" DataKeyNames="Id" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" OnSelectedIndexChanged="gVTaches_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                                <asp:BoundField />
                            </Columns>
                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
                        </asp:GridView>
                    </td>
                </tr>
    </table>
</asp:Content>
