<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluDers.OgrenciGuncelle" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
            <asp:Label for="TextBox0" runat="server" Text="Öğrenci ID:" ></asp:Label>
                </strong>
            <asp:TextBox ID="TextBox0" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TextBox1" runat="server" Text="Öğrenci Adı:" ></asp:Label>
                </strong>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TextBox2" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                </strong>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TextBox3" runat="server" Text="Öğrenci Numara:"></asp:Label>
                </strong>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TextBox4" runat="server" Text="Şifre:"></asp:Label>
                </strong>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
            <asp:Label for="TextBox5" runat="server" Text="Fotoğraf:"></asp:Label>
                </strong>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <strong>

        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" style="font-weight: bold" OnClick="Button1_Click1"   />
        </strong>
    </form>
    
</asp:Content>

