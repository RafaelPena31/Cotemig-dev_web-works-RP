<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inscricao.aspx.cs" Inherits="Workshop_Tecnologia.UI.inscricao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title>Clean Code Hacker - Se inscreva</title>
</head>
<body>
    <form id="form1" class="d-flex flex-column align-items-center" runat="server">
        <header class="mb-3 w-100">
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <div class="collapse navbar-collapse" id="navbarText">
                    <ul class="navbar-nav w-100 d-flex justify-content-around">
                        <li class="nav-item active">
                            <asp:HyperLink NavigateUrl="~/UI/Index.aspx" Text="Home" runat="server"></asp:HyperLink>
                        </li>
                        <li class="nav-item">
                            <asp:HyperLink NavigateUrl="~/UI/Consulta.aspx" Text="Consulta" runat="server"></asp:HyperLink>
                        </li>
                    </ul>
                </div>
            </nav>

            <section class="text-center">
                <h1>REALIZAR INSCRIÇÕES</h1>
            </section>
        </header>

        <div>
            <asp:HiddenField ID="id" runat="server" />
            <div class="mb-3 w-100 d-flex justify-content-between">
                <asp:Label for="nome" Text="Nome" runat="server"></asp:Label>
                <asp:TextBox ID="nome" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3 w-100 d-flex justify-content-between">
                <asp:Label for="email" Text="Email" runat="server"></asp:Label>
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3 w-100 d-flex justify-content-between">
                <asp:Label for="telefone" Text="Telefone" runat="server"></asp:Label>
                <asp:TextBox ID="telefone" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3 w-100 d-flex align-items-center flex-column">
                <asp:Label for="foto" Text="Foto" runat="server"></asp:Label>
                <asp:FileUpload ID="foto" runat="server"></asp:FileUpload>
            </div>
            <div class="mb-3 w-100 d-flex justify-content-center">
                <asp:Button ID="Salvar" CssClass="w-100" runat="server" Text="Enviar" OnClick="Salvar_Click" />
            </div>
        </div>

        <div class="form-group w-100 d-flex align-items-center flex-column text-center">
            <asp:Label Text="" ID="snackbarOK" ForeColor="Green" Visible="false" class="col-sm-2 col-form-label w-50" runat="server"></asp:Label>
            <asp:Label Text="" ID="snackbarError" ForeColor="Red" Visible="false" class="col-sm-2 col-form-label w-50" runat="server"></asp:Label>
        </div>

        <footer class="w-100 bg-secondary">
            <div class="text-center text-white">
                &copy; Copyright 2021 
                <p class="text-light">Desenvolvido por: Rafael Augusto Pena Pereira Mesquita</p>
            </div>
        </footer>
    </form>
</body>
</html>
