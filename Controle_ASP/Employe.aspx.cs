using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

namespace Controle_ASP
{
    public partial class Employe : System.Web.UI.Page
    {
        TacheContext tacheContext = new Entity.TacheContext();

        private void chargerGrid()
        {
            gVEmployes.DataSource = (from emp in tacheContext.employes select emp).ToList();
            gVEmployes.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            tbIdEmploye.ReadOnly = true;
            chargerGrid();
            if (!Page.IsPostBack)
            {
                ddlDepartementEmploye.DataSource = (from d in tacheContext.departements select d).ToList();
                ddlDepartementEmploye.DataTextField = "Nom";
                ddlDepartementEmploye.DataValueField = "Id";
                ddlDepartementEmploye.DataBind();
            }
        }

        protected void gVEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity.Employe emp = new Entity.Employe();
            Int32 id = int.Parse(gVEmployes.SelectedValue.ToString());
            emp = (from val in tacheContext.employes where val.Id == id select val).Single();
            tbNomEmploye.Text = emp.Nom;
            tbPrenomEmploye.Text = emp.Prenom;
            tbEmailEmploye.Text = emp.Email;
            tbIdEmploye.Text = emp.Id.ToString();
        }

        protected void btMAJ_Click(object sender, EventArgs e)
        {
            Entity.Employe emp = new Entity.Employe();
            Int32 id = int.Parse(gVEmployes.SelectedValue.ToString());
            emp = (from V in tacheContext.employes
                        where V.Id == id
                        select V).Single();
            emp.Nom = tbNomEmploye.Text;
            emp.Prenom = tbPrenomEmploye.Text;
            emp.Email = tbEmailEmploye.Text;
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void btAjouter_Click(object sender, EventArgs e)
        {
            Entity.Employe emp = new Entity.Employe();
            emp.Nom = tbNomEmploye.Text;
            emp.Prenom = tbPrenomEmploye.Text;
            emp.Email = tbEmailEmploye.Text;
            int id = int.Parse(ddlDepartementEmploye.SelectedValue.ToString());
            Entity.Departement dept = (from val in tacheContext.departements where val.Id == id select val).Single();
            emp.Departement = dept;
            tacheContext.employes.Add(emp);
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void btSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gVEmployes.SelectedValue.ToString());
            Entity.Employe emp = (from val in tacheContext.employes where val.Id == id select val).Single();
            tacheContext.employes.Remove(emp);
            tacheContext.SaveChanges();
            chargerGrid();
        }

        protected void btRecherche_Click(object sender, EventArgs e)
        {
            int idDept = int.Parse(ddlDepartementEmploye.SelectedIndex.ToString());
            string nom = lbNomEmploye.Text;
            gVEmployes.DataSource = (from employe in tacheContext.employes
                                     where employe.Departement.Id == idDept || employe.Nom == nom
                                     select employe).ToList();
            gVEmployes.DataBind();
        }
    }
}