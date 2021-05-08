using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Workshop_Tecnologia.BLL;
using Workshop_Tecnologia.DTO;

namespace Workshop_Tecnologia.UI
{
    public partial class inscricao : System.Web.UI.Page
    {
        private void ErrorMessage(string error)
        {
            snackbarError.Text = string.Format($@"Erro ao cadastrar: '{error}'");
            snackbarError.Visible = true;
            if (snackbarOK.Visible)
            {
                snackbarOK.Visible = false;
            }
        }

        private void SuccessMessage(string message)
        {
            snackbarOK.Text = message;
            snackbarOK.Visible = true;
            if (snackbarError.Visible)
            {
                snackbarError.Visible = false;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                InscricaoDTO inscricaoDTO = new InscricaoDTO();
                InscricaoBLL inscricaoBLL = new InscricaoBLL();
                inscricaoDTO.Nome = nome.Text;
                inscricaoDTO.Telefone = telefone.Text;
                inscricaoDTO.Email = email.Text;
                inscricaoDTO.Foto = foto.FileName.ToString();
                inscricaoBLL.Insert(inscricaoDTO);
                string localFoto = Server.MapPath("/IMG/" + inscricaoDTO.Foto);
                foto.SaveAs(localFoto);
                string successMsg = "Inscrição cadastrada com sucesso!";
                SuccessMessage(successMsg);
                nome.Text = "";
                telefone.Text = "";
                email.Text = "";
            }
            catch (Exception error)
            {
                ErrorMessage(error.Message);
            }
        }
    }
}