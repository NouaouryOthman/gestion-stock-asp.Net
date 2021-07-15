<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Departement.aspx.cs" Inherits="Controle_ASP.Departement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
                <tr>
                    <td>
                        <asp:Label ID="lbIdDeparteament" runat="server" Text="Id : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbIdDeparteament" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbNomDepartement" runat="server" Text="Nom : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbNomDepartement" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbVilleDepartement" runat="server" Text="Ville : "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbVilleDepartement" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                       <pre><asp:Button ID="btMAJ" runat="server" Text="MaJ" OnClick="btMAJ_Click"/>              <asp:Button ID="btAjouter" runat="server" Text="Ajouter" OnClick="btAjouter_Click"/>                  <asp:Button ID="btSupprimer" runat="server" Text="Supprimer" OnClick="btSupprimer_Click"/>            <asp:Button ID="Recherche" runat="server" Text="Recherche" OnClick="Recherche_Click"/>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  <asp:Button ID="BtSuppression" runat="server" Text="Suppression"  /></pre>                      
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" style="align-self:center">
                        <asp:GridView ID="gVDepartements" runat="server" OnSelectedIndexChanged="gVDepartements_SelectedIndexChanged" GridLines="Horizontal" DataKeyNames="Id" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
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
