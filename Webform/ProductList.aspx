<%@ Page Title="Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Webform.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%:Page.Title %></h2>
            </hgroup>

            <asp:ListView runat="server" id="productList" DataKeyNames="ProductID" GroupItemCount="4"
                ItemType="Webform.Models.Product"
                SelectMethod="GetProducts">
                <EmptyDataTemplate>
                    <table>
                        <tr><td>No data was returned</td></tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate><td /></EmptyItemTemplate>
                <GroupTemplate>
                    <tr runat="server" id="itemPlaceholderContainer">
                        <td runat="server" id="itemPlaceholder"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="<%#:GetRouteUrl("ProductByNameRoute", new { productName = Item.ProductName }) %>"">
                                        <img src="/Images/<%#:Item.ImagePath %>" width="100" height="75" style="border:solid" />
                                    </a>
                                   
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="<%#:GetRouteUrl("ProductByNameRoute",new { productName = Item.ProductName }) %>"">
                                        <span><%#:Item.ProductName %></span>
                                    </a>
                                     <br />
                                    <span>
                                        <b>Price:</b> <%#:String.Format("{0:c}",Item.UnitPrice) %>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>"><span class="ProductListItem"><b>Add to Cart</b></span></a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
