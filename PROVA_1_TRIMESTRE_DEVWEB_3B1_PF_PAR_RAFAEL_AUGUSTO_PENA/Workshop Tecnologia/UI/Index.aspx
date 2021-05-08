<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Workshop_Tecnologia.UI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title>Clean Code Hacker - Início</title>
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
                            <asp:HyperLink NavigateUrl="~/UI/Inscricao.aspx" Text="Inscrições" runat="server"></asp:HyperLink>
                        </li>
                        <li class="nav-item">
                            <asp:HyperLink NavigateUrl="~/UI/Consulta.aspx" Text="Consulta" runat="server"></asp:HyperLink>
                        </li>
                    </ul>
                </div>
            </nav>

            <section class="text-center">
                <h1>WORKSHOP DE TECNOLOGIA</h1>
                <h2>Clean Code Hacker - New Age (RAPPM)</h2>
                <asp:Image ID="imgHome" ImageUrl="~/IMG/banner.png" AlternateText="workshop" runat="server" Height="388px" Width="563px" />
            </section>
        </header>

        <main class="mb-3">
            <section class="text-center d-flex flex-column align-items-center w-100">
                <article class="w-50">
                    O Clean Code Hacker é uma maratona anual de programação onde abordamos as melhores prática programáticas para cada área do desenvolvimento em conjunto de estudos arquiteturais e muito café.
                </article>
            </section>
        </main>

        <section class="text-center">
            <article>
                <p>Programação do evento</p>
                <asp:Table ID="programacao" CellPadding="10"
                    GridLines="Both"
                    HorizontalAlign="Center" runat="server">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>Horário</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Descrição</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell>
                             08:10 - 09:00
                        </asp:TableCell>
                        <asp:TableCell>
                            Check In - Palestra inicial
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            09:10 - 10:10
                        </asp:TableCell>
                        <asp:TableCell>
                            Uncle Bob - Clean Code
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            10:10 - 10:30
                        </asp:TableCell>
                        <asp:TableCell>
                            Coffe Break
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            10:30 - 11:30
                        </asp:TableCell>
                        <asp:TableCell>
                            Kent Beck - TDD no dia a dia
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            11:40 - 12:40
                        </asp:TableCell>
                        <asp:TableCell>
                            Rafael Pena - MVVM no dia a dia de um dev mobile
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            12:40 - 14:00
                        </asp:TableCell>
                        <asp:TableCell>
                            Lunch Time
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            14:00 - 16:30
                        </asp:TableCell>
                        <asp:TableCell>
                            Code Time
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </article>
        </section>

        <section class="d-flex flex-column align-items-center">
            <p class="font-weight-bold">Quer participar desse evento incrível?</p>
            <asp:HyperLink Text="Inscreva-se" NavigateUrl="~/UI/Inscricao.aspx" runat="server"></asp:HyperLink>
        </section>

        <footer class="w-100 bg-secondary">
            <div class="text-center text-white">
                &copy; Copyright 2021 
                <p class="text-light">Desenvolvido por: Rafael Augusto Pena Pereira Mesquita</p>
            </div>
        </footer>
    </form>
</body>
</html>
