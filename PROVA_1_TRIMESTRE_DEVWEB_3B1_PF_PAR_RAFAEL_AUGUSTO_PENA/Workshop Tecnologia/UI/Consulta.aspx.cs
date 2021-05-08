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
    public partial class consulta : System.Web.UI.Page
    {
        InscricaoBLL inscricaoBLL = new InscricaoBLL();
        InscricaoDTO inscricaoDTO = new InscricaoDTO();
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
        public void ExibirGridView()
        {
            GridInscricao.DataSource = inscricaoBLL.getInscricao();
            GridInscricao.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ExibirGridView();
            if (!Page.IsPostBack)
            {
                GridInscricao.DataBind();

            }
        }
        protected void GridInscricao_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridInscricao.PageIndex = e.NewEditIndex;
            ExibirGridView();
        }
        protected void GridInscricao_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridInscricao.EditIndex = -1;
            ExibirGridView();
        }
        protected void GridInscricao_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                inscricaoDTO.Id = Convert.ToInt32(GridInscricao.DataKeys[e.RowIndex].Value.ToString());
                inscricaoDTO.Nome = e.NewValues[0]?.ToString().Length > 0 ? e.NewValues[0].ToString() : "";
                inscricaoDTO.Email = e.NewValues[1]?.ToString().Length > 0 ? e.NewValues[1].ToString() : "";
                inscricaoDTO.Telefone = e.NewValues[2]?.ToString().Length > 0 ? e.NewValues[2].ToString() : "";

                FileUpload profileImage = (FileUpload)GridInscricao.Rows[e.RowIndex].FindControl("fileupFoto");

                if (profileImage.HasFile)
                {
                    String localImagem = Server.MapPath("~/IMG/PROFILE/" + profileImage.FileName);
                    profileImage.SaveAs(localImagem);
                    inscricaoDTO.Foto = profileImage.FileName.ToString();
                }

                inscricaoBLL.Update(inscricaoDTO);
                GridInscricao.EditIndex = -1;
                string successMsg = "Atualização cadastrada com sucesso!";
                SuccessMessage(successMsg);
                ExibirGridView();
            }
            catch (Exception error)
            {
                ErrorMessage(error.Message);
            }
        }
    }
}