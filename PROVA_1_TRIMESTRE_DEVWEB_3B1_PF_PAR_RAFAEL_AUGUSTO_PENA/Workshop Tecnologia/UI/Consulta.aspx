<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Workshop_Tecnologia.UI.consulta" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title>Clean Code Hacker - Inscrições</title>
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
                    </ul>
                </div>
            </nav>

            <section class="text-center">
                <h1>CONSULTAR INSCRIÇÕES</h1>
            </section>
        </header>
        <div>
            <asp:GridView
                ID="GridInscricao"
                OnRowEditing="GridInscricao_RowEditing"
                OnRowCancelingEdit="GridInscricao_RowCancelingEdit"
                OnRowUpdating="GridInscricao_RowUpdating"
                AutoGenerateColumns="false"
                EnableViewState="False"
                DataKeyNames="id"
                runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="Id">
                        <ItemTemplate>
                            <asp:Label ID="labelId" runat="server" Text='<%# Eval("id")%>'>
                            </asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nome">
                        <ItemTemplate>
                            <asp:Label ID="labelNome" runat="server" Text='<%# Eval("nome")%>'>
                            </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textNome" Text='<%# Bind("nome")%>' runat="server">
                            </asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label ID="labelEmail" runat="server" Text='<%# Eval("email")%>'>
                            </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textEmail" Text='<%# Bind("email")%>' runat="server">
                            </asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Telefone">
                        <ItemTemplate>
                            <asp:Label ID="labelTelefone" runat="server" Text='<%# Eval("telefone")%>'>
                            </asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textTelefone" Text='<%# Bind("telefone")%>' runat="server">
                            </asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Foto">
                        <ItemTemplate>
                            <asp:Image ID="labelFoto" runat="server" ImageUrl='<%# "~/IMG/PROFILE/" + Eval("foto")%>' Width="150" Height="190"></asp:Image>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:FileUpload ID="fileupFoto" runat="server"></asp:FileUpload>
                        </EditItemTemplate>
                    </asp:TemplateField>

                    <asp:CommandField ShowEditButton="true" ButtonType="Link" HeaderText="Editar" runat="server"></asp:CommandField>
                </Columns>
            </asp:GridView>
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
